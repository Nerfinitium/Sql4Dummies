﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace SqlForDummies
{
    #region Bağlamlar
    
    /// <summary>
    /// Kullanılabilir Meta Veri Belgeleri yok.
    /// </summary>
    public partial class Model1Container : ObjectContext
    {
        #region Oluşturucular
    
        /// <summary>
        /// Yeni Model1Container nesnesini, uygulama yapılandırma dosyasının 'Model1Container' bölümünde bulunan bağlantı dizesini kullanarak başlatır.
        /// </summary>
        public Model1Container() : base("name=Model1Container", "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Yeni bir Model1Container nesnesi başlatın.
        /// </summary>
        public Model1Container(string connectionString) : base(connectionString, "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Yeni bir Model1Container nesnesi başlatın.
        /// </summary>
        public Model1Container(EntityConnection connection) : base(connection, "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Kısmi Metotlar
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
