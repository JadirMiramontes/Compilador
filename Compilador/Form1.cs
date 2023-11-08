using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}
		private void btnAnalisisLexico_Click(object sender, EventArgs e)
		{
			string sourceCode = rtCodigo.Text;
			List<Token> symbolTable = AnalizarL(sourceCode);

			dgvTablaSimbolos.Rows.Clear();

			foreach (Token token in symbolTable)
			{
				dgvTablaSimbolos.Rows.Add(token.Type, token.Value);
			}
		}


		/*Analisis Lexico*/
		private List<Token> AnalizarL(string sourceCode)
		{
			List<Token> symbolTable = new List<Token>();

			string keywordPattern = "\\b(si|sino|mientras|para|entero|cadena|bool|publico|privado|clase|flotante)\\b";
			string operatorPattern = @"[+\-\*\/\=]";
			string numberPattern = "\\b[0-9]+\\b";
			string whitespacePattern = "\\s+";

			string pattern = $"({keywordPattern}|{operatorPattern}|{numberPattern}|{whitespacePattern})";

			MatchCollection matches = Regex.Matches(sourceCode, pattern);

			foreach (Match match in matches)
			{
				if (!string.IsNullOrWhiteSpace(match.Value))
				{
					TokenType type = GetTokenType(match.Value);
					symbolTable.Add(new Token(type, match.Value));
				}
			}
			return symbolTable;
		}


		private TokenType GetTokenType(string tokenValue)
		{
			if (Regex.IsMatch(tokenValue, "\\b(si|sino|mientras|para|publico|privado|clase)\\b"))
			{
				return TokenType.Palabra_Clave;
			}
			else if (Regex.IsMatch(tokenValue, "\\b(entero|cadena|bool|flotante)\\b"))
			{
				return TokenType.Tipo;
			}
			else if (Regex.IsMatch(tokenValue, "\\b[0-9]+\\b"))
			{
				return TokenType.Numero;
			}
			else if (Regex.IsMatch(tokenValue, "\\s+"))
			{
				return TokenType.Espacio_Blanco;
			}
			else if (Regex.IsMatch(tokenValue, @"[+\-\*\/\=]"))
			{
				return TokenType.Operador;
			}
			else
			{
				return TokenType.Otros;
			}
		}

		enum TokenType
		{
			Palabra_Clave, Tipo, Numero, Espacio_Blanco, Operador, Otros, Error
		}

		class Token
		{
			public TokenType Type { get; }
			public string Value { get; }

			public Token(TokenType type, string value)
			{
				Type = type;
				Value = value;
			}
		}

		private void btnAnalizadorSintactico_Click(object sender, EventArgs e)
		{

			string sourceCode = rtCodigo.Text;
			string[] lines = sourceCode.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
			List<Error> errorList = AnalizarSintaxis(lines);

			dgvErrores.Rows.Clear();

			foreach (Error error in errorList)
			{
				dgvErrores.Rows.Add(error.LineNumber, error.Message);
			}
		}

		private List<Error> AnalizarSintaxis(string[] lines)
		{
			List<Error> errorList = new List<Error>();
			HashSet<string> keywords = new HashSet<string> { "si", "sino", "mientras", "para" };

			for (int i = 0; i < lines.Length; i++)
			{
				string line = lines[i].Trim(); // Eliminar espacios en blanco al principio y al final de la línea
				if (!string.IsNullOrWhiteSpace(line))
				{
					if (!line.EndsWith(")") && keywords.Any(keyword => line.EndsWith(keyword)))
					{
						errorList.Add(new Error(i + 1, $"Error: Palabra clave '{line.Split(' ')[0]}' mal declarada. Falta paréntesis de cierre."));
					}

					string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
					bool declarationFound = false;

					foreach (string word in words)
					{
						if (declarationFound && word.EndsWith("="))
						{
							errorList.Add(new Error(i + 1, $"Error: Variable '{word.Trim('=')}' no está completamente declarada en la línea {i + 1}."));
						}

						if (word.Contains(";"))
						{
							errorList.Add(new Error(i + 1, $"Error: No se deben usar ';' al finalizar las líneas."));
						}

						if (keywords.Contains(word))
						{
							declarationFound = true;
							if (!word.EndsWith("("))
							{
								errorList.Add(new Error(i + 1, $"Error: Palabra clave '{word}' mal declarada. Falta paréntesis de apertura."));
							}
						}

						if (keywords.Contains(word))
						{
							declarationFound = true;
						}
					}
				}
			}

			return errorList;
		}

		class Error
		{
			public int LineNumber { get; }
			public string Message { get; }
			public Error(int lineNumber, string message)
			{
				LineNumber = lineNumber;
				Message = message;
			}
		}

		private void btnCodigoIntermedio_Click(object sender, EventArgs e)
		{
			string codigoFuente = rtCodigo.Text;
			string keywordPattern = "\\b(si|sino|mientras|para|entero|cadena|bool|publico|privado|clase|flotante)\\b";
			string operatorPattern = @"[+\-\*\/\=]";
			string numberPattern = "\\b[0-9]+\\b";
			string whitespacePattern = "\\s+";

			Regex regexKeyword = new Regex(keywordPattern);
			Regex regexOperator = new Regex(operatorPattern);
			Regex regexNumber = new Regex(numberPattern);
			Regex regexWhitespace = new Regex(whitespacePattern);

			string[] tokens = regexWhitespace.Split(codigoFuente);
			string codigoIntermedioPython = "";

			foreach (string token in tokens)
			{
				if (!string.IsNullOrWhiteSpace(token))
				{
					if (regexKeyword.IsMatch(token))
					{
						// Convertir palabras clave de C# a Python
						string palabraClavePython = ConvertirPalabraClave(token);
						codigoIntermedioPython += palabraClavePython + " ";
					}
					else if (regexOperator.IsMatch(token))
					{
						// Mantener los operadores tal como están
						codigoIntermedioPython += token + " ";
					}
					else if (regexNumber.IsMatch(token))
					{
						// Mantener los números tal como están
						codigoIntermedioPython += token + " ";
					}
					else
					{
						// Mantener los identificadores tal como están
						codigoIntermedioPython += token + " ";
					}
				}
			}

			// Mostrar el código intermedio en rtCodigoIntermedio
			rtCodigoIntermedio.Text = codigoIntermedioPython;
		}

		private string ConvertirPalabraClave(string palabraClave)
		{
			// Realizar conversiones específicas de C# a Python para palabras clave
			switch (palabraClave)
			{
				case "si":
					return "if";
				case "sino":
					return "else";
				case "mientras":
					return "while";
				case "para":
					return "for";
				case "entero":
					return "int";
				case "cadena":
					return "str";
				case "bool":
					return "bool";
				case "publico":
					return "public";
				case "privado":
					return "private";
				case "clase":
					return "class";
				case "flotante":
					return "float";
				default:
					// Si no se encuentra una coincidencia, devolver la palabra clave tal como está
					return palabraClave;
			}
		}

	}
}