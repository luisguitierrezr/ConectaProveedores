namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Zpgra9eqp0qKIoXUAxp4zQ)
///  <code>RC_bd42fd4399da47c92c88d912cd87df67</code> that represent
/// s
///  <code>InvoiceOrderAccountingOrderMainOrderDetailInvoiceExtendedCompanySupplierProject_Asset_Service
/// PaymentMethodsRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceOrderAccountingOrderMainOrderDetailInvoiceExtendedCompanySupplierProject_Asset_ServicePaymentMethodsRegionRecord
public partial struct RC_bd42fd4399da47c92c88d912cd87df67 : ITypedRecord<RC_bd42fd4399da47c92c88d912cd87df67> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdOrderAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OM_CLcG8i2ozjcXqmlxkRg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdProject_Asset_Service = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*waIIG87O4_GzAGpguX_Gjg");
internal static readonly GlobalObjectKey IdPaymentMethods = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GI4gRZFLoSpiPN8Zdg6Ofg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord ssENProject_Asset_Service;

public EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord ssENPaymentMethods;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_bd42fd4399da47c92c88d912cd87df67() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENOrderAccounting = new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENProject_Asset_Service = new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
ssENPaymentMethods = new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[10];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(19,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(39,false);
    all[4] = new BitArray(19,false);
    all[5] = new BitArray(11,false);
    all[6] = new BitArray(28,false);
    all[7] = new BitArray(7,false);
    all[8] = new BitArray(9,false);
    all[9] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENProject_Asset_Service.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENPaymentMethods.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENOrderAccounting.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENOrderDetail.OptimizedAttributes = value[3];
    ssENInvoiceExtended.OptimizedAttributes = value[4];
    ssENCompany.OptimizedAttributes = value[5];
    ssENSupplier.OptimizedAttributes = value[6];
    ssENProject_Asset_Service.OptimizedAttributes = value[7];
    ssENPaymentMethods.OptimizedAttributes = value[8];
    ssENRegion.OptimizedAttributes = value[9];
    }
}
get{
    BitArray[] all = new BitArray[10];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENOrderAccounting.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENOrderDetail.OptimizedAttributes;
    all[4] = ssENInvoiceExtended.OptimizedAttributes;
    all[5] = ssENCompany.OptimizedAttributes;
    all[6] = ssENSupplier.OptimizedAttributes;
    all[7] = ssENProject_Asset_Service.OptimizedAttributes;
    all[8] = ssENPaymentMethods.OptimizedAttributes;
    all[9] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
ssENOrderAccounting.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENProject_Asset_Service.Read( r, ref index);
ssENPaymentMethods.Read( r, ref index);
ssENRegion.Read( r, ref index);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_bd42fd4399da47c92c88d912cd87df67 r) {
this = r;
}


public static bool operator == (RC_bd42fd4399da47c92c88d912cd87df67 a, RC_bd42fd4399da47c92c88d912cd87df67 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENOrderAccounting != b.ssENOrderAccounting) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENProject_Asset_Service != b.ssENProject_Asset_Service) return false;
if (a.ssENPaymentMethods != b.ssENPaymentMethods) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_bd42fd4399da47c92c88d912cd87df67 a, RC_bd42fd4399da47c92c88d912cd87df67 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bd42fd4399da47c92c88d912cd87df67)) return false;
return (this == (RC_bd42fd4399da47c92c88d912cd87df67)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENOrderAccounting.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENProject_Asset_Service.GetHashCode()
 ^ ssENPaymentMethods.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENOrderAccounting.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENProject_Asset_Service.RecursiveReset();
ssENPaymentMethods.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENOrderAccounting.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENProject_Asset_Service.InternalRecursiveSave();
ssENPaymentMethods.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_bd42fd4399da47c92c88d912cd87df67 Duplicate() {
RC_bd42fd4399da47c92c88d912cd87df67 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENOrderAccounting = (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord)this.ssENOrderAccounting.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENProject_Asset_Service = (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord)this.ssENProject_Asset_Service.Duplicate();
t.ssENPaymentMethods = (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord)this.ssENPaymentMethods.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "orderaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccounting")) variable.Value = ssENOrderAccounting; else variable.Optimized = true;
variable.SetFieldName("orderaccounting");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "project_asset_service") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project_Asset_Service")) variable.Value = ssENProject_Asset_Service; else variable.Optimized = true;
variable.SetFieldName("project_asset_service");
} else if (head == "paymentmethods") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethods")) variable.Value = ssENPaymentMethods; else variable.Optimized = true;
variable.SetFieldName("paymentmethods");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdOrderAccounting) {
return ssENOrderAccounting;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdProject_Asset_Service) {
return ssENProject_Asset_Service;
}
if (key == IdPaymentMethods) {
return ssENPaymentMethods;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdOrderAccounting.Key.AsGuid) {
return ssENOrderAccounting;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdProject_Asset_Service.Key.AsGuid) {
return ssENProject_Asset_Service;
}
if (attributeKey == IdPaymentMethods.Key.AsGuid) {
return ssENPaymentMethods;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENOrderAccounting.FillFromOther((IRecord) other.AttributeGet(IdOrderAccounting));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENProject_Asset_Service.FillFromOther((IRecord) other.AttributeGet(IdProject_Asset_Service));
ssENPaymentMethods.FillFromOther((IRecord) other.AttributeGet(IdPaymentMethods));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_bd42fd4399da47c92c88d912cd87df67
/// <summary>
/// RecordList type
///  <code>InvoiceOrderAccountingOrderMainOrderDetailInvoiceExtendedCompanySupplierProject_Asset_Service
/// PaymentMethodsRegionRecordList</code> that represents a record list of <code>Invoice,
///  OrderAccounting, OrderMain, OrderDetail, InvoiceExtended, Company, Supplier, Project_Asset_Service
/// , PaymentMethods, Region</code>
/// </summary>
public partial class RL_72bc9c8db8dc80bec32b40b958e9af79 : GenericRecordList<RC_bd42fd4399da47c92c88d912cd87df67>, IEnumerable, IEnumerator {

protected override RC_bd42fd4399da47c92c88d912cd87df67 GetElementDefaultValue() {
return new RC_bd42fd4399da47c92c88d912cd87df67();
}

public T[] ToArray<T>(Func<RC_bd42fd4399da47c92c88d912cd87df67, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_72bc9c8db8dc80bec32b40b958e9af79 recordList, Func<RC_bd42fd4399da47c92c88d912cd87df67, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_72bc9c8db8dc80bec32b40b958e9af79(RC_bd42fd4399da47c92c88d912cd87df67[] array) {
  RL_72bc9c8db8dc80bec32b40b958e9af79 result = new RL_72bc9c8db8dc80bec32b40b958e9af79();
result.InnerFromArray(array);
    return result;
}

public static RL_72bc9c8db8dc80bec32b40b958e9af79 ToList<T>(T[] array, Func <T, RC_bd42fd4399da47c92c88d912cd87df67> converter) {
  RL_72bc9c8db8dc80bec32b40b958e9af79 result = new RL_72bc9c8db8dc80bec32b40b958e9af79();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_72bc9c8db8dc80bec32b40b958e9af79 FromRestList<T>(RestList<T> restList, Func <T, RC_bd42fd4399da47c92c88d912cd87df67> converter) {
  RL_72bc9c8db8dc80bec32b40b958e9af79 result = new RL_72bc9c8db8dc80bec32b40b958e9af79();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_72bc9c8db8dc80bec32b40b958e9af79() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[10];
def[0] = new BitArray(24,false);
def[1] = new BitArray(19,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(39,false);
def[4] = new BitArray(19,false);
def[5] = new BitArray(11,false);
def[6] = new BitArray(28,false);
def[7] = new BitArray(7,false);
def[8] = new BitArray(9,false);
def[9] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bd42fd4399da47c92c88d912cd87df67> NewList() {
return new RL_72bc9c8db8dc80bec32b40b958e9af79();
}


} // RL_72bc9c8db8dc80bec32b40b958e9af79
}

