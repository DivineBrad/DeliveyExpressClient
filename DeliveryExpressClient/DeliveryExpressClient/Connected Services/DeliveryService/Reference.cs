﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeliveryExpressClient.DeliveryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Fault", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Fault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Error_reasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Error_detailField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int code {
            get {
                return this.codeField;
            }
            set {
                if ((this.codeField.Equals(value) != true)) {
                    this.codeField = value;
                    this.RaisePropertyChanged("code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Error_reason {
            get {
                return this.Error_reasonField;
            }
            set {
                if ((object.ReferenceEquals(this.Error_reasonField, value) != true)) {
                    this.Error_reasonField = value;
                    this.RaisePropertyChanged("Error_reason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Error_detail {
            get {
                return this.Error_detailField;
            }
            set {
                if ((object.ReferenceEquals(this.Error_detailField, value) != true)) {
                    this.Error_detailField = value;
                    this.RaisePropertyChanged("Error_detail");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/DeliveryExpress.Model")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DeliveryExpressClient.DeliveryService.ItemImage ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Desc {
            get {
                return this.DescField;
            }
            set {
                if ((object.ReferenceEquals(this.DescField, value) != true)) {
                    this.DescField = value;
                    this.RaisePropertyChanged("Desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DeliveryExpressClient.DeliveryService.ItemImage Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemId {
            get {
                return this.ItemIdField;
            }
            set {
                if ((this.ItemIdField.Equals(value) != true)) {
                    this.ItemIdField = value;
                    this.RaisePropertyChanged("ItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemImage", Namespace="http://schemas.datacontract.org/2004/07/DeliveryExpress.Model")]
    [System.SerializableAttribute()]
    public partial class ItemImage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ImgIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ImgId {
            get {
                return this.ImgIdField;
            }
            set {
                if ((this.ImgIdField.Equals(value) != true)) {
                    this.ImgIdField = value;
                    this.RaisePropertyChanged("ImgId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserType", Namespace="http://schemas.datacontract.org/2004/07/DeliveryExpress.Model")]
    [System.SerializableAttribute()]
    public partial class UserType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TypeId {
            get {
                return this.TypeIdField;
            }
            set {
                if ((this.TypeIdField.Equals(value) != true)) {
                    this.TypeIdField = value;
                    this.RaisePropertyChanged("TypeId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DeliveryService.IDeliveryService")]
    public interface IDeliveryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/DeleteOrder", ReplyAction="http://tempuri.org/IDeliveryService/DeleteOrderResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DeliveryExpressClient.DeliveryService.Fault), Action="http://tempuri.org/IDeliveryService/DeleteOrderFaultFault", Name="Fault")]
        int DeleteOrder(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/DeleteOrder", ReplyAction="http://tempuri.org/IDeliveryService/DeleteOrderResponse")]
        System.Threading.Tasks.Task<int> DeleteOrderAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/UpdateItem", ReplyAction="http://tempuri.org/IDeliveryService/UpdateItemResponse")]
        int UpdateItem(DeliveryExpressClient.DeliveryService.Item i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/UpdateItem", ReplyAction="http://tempuri.org/IDeliveryService/UpdateItemResponse")]
        System.Threading.Tasks.Task<int> UpdateItemAsync(DeliveryExpressClient.DeliveryService.Item i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/CreateItem", ReplyAction="http://tempuri.org/IDeliveryService/CreateItemResponse")]
        int CreateItem(DeliveryExpressClient.DeliveryService.Item i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/CreateItem", ReplyAction="http://tempuri.org/IDeliveryService/CreateItemResponse")]
        System.Threading.Tasks.Task<int> CreateItemAsync(DeliveryExpressClient.DeliveryService.Item i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/GetItems", ReplyAction="http://tempuri.org/IDeliveryService/GetItemsResponse")]
        DeliveryExpressClient.DeliveryService.Item[] GetItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/GetItems", ReplyAction="http://tempuri.org/IDeliveryService/GetItemsResponse")]
        System.Threading.Tasks.Task<DeliveryExpressClient.DeliveryService.Item[]> GetItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/GetItem", ReplyAction="http://tempuri.org/IDeliveryService/GetItemResponse")]
        DeliveryExpressClient.DeliveryService.Item GetItem(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/GetItem", ReplyAction="http://tempuri.org/IDeliveryService/GetItemResponse")]
        System.Threading.Tasks.Task<DeliveryExpressClient.DeliveryService.Item> GetItemAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/DeleteItem", ReplyAction="http://tempuri.org/IDeliveryService/DeleteItemResponse")]
        int DeleteItem(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/DeleteItem", ReplyAction="http://tempuri.org/IDeliveryService/DeleteItemResponse")]
        System.Threading.Tasks.Task<int> DeleteItemAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/GetItemsByName", ReplyAction="http://tempuri.org/IDeliveryService/GetItemsByNameResponse")]
        DeliveryExpressClient.DeliveryService.Item[] GetItemsByName(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/GetItemsByName", ReplyAction="http://tempuri.org/IDeliveryService/GetItemsByNameResponse")]
        System.Threading.Tasks.Task<DeliveryExpressClient.DeliveryService.Item[]> GetItemsByNameAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/Authenticate", ReplyAction="http://tempuri.org/IDeliveryService/AuthenticateResponse")]
        bool Authenticate(string username, string password, int typeid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/Authenticate", ReplyAction="http://tempuri.org/IDeliveryService/AuthenticateResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateAsync(string username, string password, int typeid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/getTypes", ReplyAction="http://tempuri.org/IDeliveryService/getTypesResponse")]
        DeliveryExpressClient.DeliveryService.UserType[] getTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeliveryService/getTypes", ReplyAction="http://tempuri.org/IDeliveryService/getTypesResponse")]
        System.Threading.Tasks.Task<DeliveryExpressClient.DeliveryService.UserType[]> getTypesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDeliveryServiceChannel : DeliveryExpressClient.DeliveryService.IDeliveryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeliveryServiceClient : System.ServiceModel.ClientBase<DeliveryExpressClient.DeliveryService.IDeliveryService>, DeliveryExpressClient.DeliveryService.IDeliveryService {
        
        public DeliveryServiceClient() {
        }
        
        public DeliveryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DeliveryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeliveryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeliveryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int DeleteOrder(int id) {
            return base.Channel.DeleteOrder(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteOrderAsync(int id) {
            return base.Channel.DeleteOrderAsync(id);
        }
        
        public int UpdateItem(DeliveryExpressClient.DeliveryService.Item i) {
            return base.Channel.UpdateItem(i);
        }
        
        public System.Threading.Tasks.Task<int> UpdateItemAsync(DeliveryExpressClient.DeliveryService.Item i) {
            return base.Channel.UpdateItemAsync(i);
        }
        
        public int CreateItem(DeliveryExpressClient.DeliveryService.Item i) {
            return base.Channel.CreateItem(i);
        }
        
        public System.Threading.Tasks.Task<int> CreateItemAsync(DeliveryExpressClient.DeliveryService.Item i) {
            return base.Channel.CreateItemAsync(i);
        }
        
        public DeliveryExpressClient.DeliveryService.Item[] GetItems() {
            return base.Channel.GetItems();
        }
        
        public System.Threading.Tasks.Task<DeliveryExpressClient.DeliveryService.Item[]> GetItemsAsync() {
            return base.Channel.GetItemsAsync();
        }
        
        public DeliveryExpressClient.DeliveryService.Item GetItem(int id) {
            return base.Channel.GetItem(id);
        }
        
        public System.Threading.Tasks.Task<DeliveryExpressClient.DeliveryService.Item> GetItemAsync(int id) {
            return base.Channel.GetItemAsync(id);
        }
        
        public int DeleteItem(int id) {
            return base.Channel.DeleteItem(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteItemAsync(int id) {
            return base.Channel.DeleteItemAsync(id);
        }
        
        public DeliveryExpressClient.DeliveryService.Item[] GetItemsByName(string value) {
            return base.Channel.GetItemsByName(value);
        }
        
        public System.Threading.Tasks.Task<DeliveryExpressClient.DeliveryService.Item[]> GetItemsByNameAsync(string value) {
            return base.Channel.GetItemsByNameAsync(value);
        }
        
        public bool Authenticate(string username, string password, int typeid) {
            return base.Channel.Authenticate(username, password, typeid);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateAsync(string username, string password, int typeid) {
            return base.Channel.AuthenticateAsync(username, password, typeid);
        }
        
        public DeliveryExpressClient.DeliveryService.UserType[] getTypes() {
            return base.Channel.getTypes();
        }
        
        public System.Threading.Tasks.Task<DeliveryExpressClient.DeliveryService.UserType[]> getTypesAsync() {
            return base.Channel.getTypesAsync();
        }
    }
}
