﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desafio_Mantis.Queries {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class UsuariosQueries {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UsuariosQueries() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Desafio_Mantis.Queries.UsuariosQueries", typeof(UsuariosQueries).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a DELETE FROM mantis_user_table WHERE username=&apos;$username&apos;;DELETE  FROM mantis_email_table
        ///WHERE email=&apos;$email&apos;;.
        /// </summary>
        internal static string DelataUsuario {
            get {
                return ResourceManager.GetString("DelataUsuario", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a DELETE FROM mantis_email_table
        ///WHERE email=&apos;$email&apos;;.
        /// </summary>
        internal static string DeletaEmailUsuario {
            get {
                return ResourceManager.GetString("DeletaEmailUsuario", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a DELETE  FROM mantis_user_table
        ///WHERE username&lt;&gt;&apos;administrator&apos;.
        /// </summary>
        internal static string DetalaTodosUsuariosExcetoAdministrator {
            get {
                return ResourceManager.GetString("DetalaTodosUsuariosExcetoAdministrator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT mantis_user_table.password 
        ///from mantis_user_table 
        ///WHERE mantis_user_table.username = &apos;$username&apos;;.
        /// </summary>
        internal static string RetornaSenhaUsuario {
            get {
                return ResourceManager.GetString("RetornaSenhaUsuario", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT count(*)
        ///from mantis_user_table 
        ///WHERE mantis_user_table.username = &apos;$username&apos;;.
        /// </summary>
        internal static string RetornaUsuario {
            get {
                return ResourceManager.GetString("RetornaUsuario", resourceCulture);
            }
        }
    }
}
