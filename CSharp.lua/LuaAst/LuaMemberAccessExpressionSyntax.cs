﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLua.LuaAst {
    public sealed class LuaMemberAccessExpressionSyntax : LuaExpressionSyntax {
        public LuaExpressionSyntax Expression { get; }
        public LuaIdentifierNameSyntax Name { get; }
        public string OperatorToken { get; }

        public LuaMemberAccessExpressionSyntax(LuaExpressionSyntax expression, LuaIdentifierNameSyntax name, bool isObjectColon) {
            Expression = expression;
            Name = name;
            OperatorToken = isObjectColon ? Tokens.ObjectColon : Tokens.Dot;
        }

        internal override void Render(LuaRenderer renderer) {
            renderer.Render(this);
        }
    }
}