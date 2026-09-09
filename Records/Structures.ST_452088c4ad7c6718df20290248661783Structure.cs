namespace ssConectaProveedores {
/// <summary>
/// [Structure] UploadValidationData (l9n2JpOSKk+SxXVhgOQCsQ)
///  <code>ST_452088c4ad7c6718df20290248661783Structure</code> that represent
/// s <code>UploadValidationData</code> <p>Description: </p>
/// </summary>
// Name: UploadValidationData
public partial struct ST_452088c4ad7c6718df20290248661783Structure : ITypedRecord<ST_452088c4ad7c6718df20290248661783Structure> {
internal static readonly GlobalObjectKey IdCostCenterId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qqui_MIX4U+5P+fYu8EFGg");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*r38Ge5YCGkyObXbmJaphAA");
internal static readonly GlobalObjectKey IdProject = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jPHIAZycjEK3qdrk6EVjfg");
internal static readonly GlobalObjectKey IdPaymentMethodId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gDkRHY735UWbcnLMgaNtrQ");
internal static readonly GlobalObjectKey IdPaymentTermsId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MlGfsRaoYkmgsDkmTFQ8uQ");
internal static readonly GlobalObjectKey IdRegionFI = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*S7LCfxjyY0mCFF+V2Kk0Rg");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hSDIjxoEfkuTS6CdnZwcIg");
internal static readonly GlobalObjectKey IdSupplierIsForeigner = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HBhONSL72kOnvdmXHDKWzQ");
internal static readonly GlobalObjectKey IdSupplierLugarExpedicion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+M8Vbfdt4028PtZdI7Lzkg");
internal static readonly GlobalObjectKey IdSupplierNr = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NXpefRnlGk+ob0KqsfXM7w");
internal static readonly GlobalObjectKey IdSupplierRFC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6T_CKuERf0K8W235eXIPhA");
internal static readonly GlobalObjectKey IdSupplierSociety = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*m02VyAoxQ0iqHzpkvCzw8g");
internal static readonly GlobalObjectKey IdIsAnticipoWithoutInv = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5EI0HnqcyU+Zw0QGTX52rQ");
internal static readonly GlobalObjectKey IdIsAnticipoWithInv = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*liI75O+8XUGjCUjhnfrNog");
internal static readonly GlobalObjectKey IdInvoiceUsageKeyList = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DZNNAR97R0OkOPDwDwGuJQ");

public long ssCostCenterId;

public string ssCurrency;

public string ssProject;

public long ssPaymentMethodId;

public long ssPaymentTermsId;

public string ssRegionFI;

public string ssTotalAmount;

public bool ssSupplierIsForeigner;

public string ssSupplierLugarExpedicion;

public string ssSupplierNr;

public string ssSupplierRFC;

public string ssSupplierSociety;

public bool ssIsAnticipoWithoutInv;

public bool ssIsAnticipoWithInv;

public BasicTypeList<string> ssInvoiceUsageKeyList;


public BitArray OptimizedAttributes;

public ST_452088c4ad7c6718df20290248661783Structure() {
OptimizedAttributes = null;
ssCostCenterId = 0L;
ssCurrency = "";
ssProject = "";
ssPaymentMethodId = 0L;
ssPaymentTermsId = 0L;
ssRegionFI = "";
ssTotalAmount = "";
ssSupplierIsForeigner = false;
ssSupplierLugarExpedicion = "";
ssSupplierNr = "";
ssSupplierRFC = "";
ssSupplierSociety = "";
ssIsAnticipoWithoutInv = false;
ssIsAnticipoWithInv = false;
ssInvoiceUsageKeyList = new BasicTypeList<string>();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssCostCenterId = r.ReadEntityReferenceLongInteger(index++, "UploadValidationData.CostCenterId", 0L);
ssCurrency = r.ReadEntityReferenceText(index++, "UploadValidationData.Currency", "");
ssProject = r.ReadText(index++, "UploadValidationData.Project", "");
ssPaymentMethodId = r.ReadEntityReferenceLongInteger(index++, "UploadValidationData.PaymentMethodId", 0L);
ssPaymentTermsId = r.ReadEntityReferenceLongInteger(index++, "UploadValidationData.PaymentTermsId", 0L);
ssRegionFI = r.ReadText(index++, "UploadValidationData.RegionFI", "");
ssTotalAmount = r.ReadText(index++, "UploadValidationData.TotalAmount", "");
ssSupplierIsForeigner = r.ReadBoolean(index++, "UploadValidationData.SupplierIsForeigner", false);
ssSupplierLugarExpedicion = r.ReadText(index++, "UploadValidationData.SupplierLugarExpedicion", "");
ssSupplierNr = r.ReadText(index++, "UploadValidationData.SupplierNr", "");
ssSupplierRFC = r.ReadText(index++, "UploadValidationData.SupplierRFC", "");
ssSupplierSociety = r.ReadText(index++, "UploadValidationData.SupplierSociety", "");
ssIsAnticipoWithoutInv = r.ReadBoolean(index++, "UploadValidationData.IsAnticipoWithoutInv", false);
ssIsAnticipoWithInv = r.ReadBoolean(index++, "UploadValidationData.IsAnticipoWithInv", false);
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
public void ReadIM(ST_452088c4ad7c6718df20290248661783Structure r) {
this = r;
}


public static bool operator == (ST_452088c4ad7c6718df20290248661783Structure a, ST_452088c4ad7c6718df20290248661783Structure b) {
if (a.ssCostCenterId != b.ssCostCenterId) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssProject != b.ssProject) return false;
if (a.ssPaymentMethodId != b.ssPaymentMethodId) return false;
if (a.ssPaymentTermsId != b.ssPaymentTermsId) return false;
if (a.ssRegionFI != b.ssRegionFI) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssSupplierIsForeigner != b.ssSupplierIsForeigner) return false;
if (a.ssSupplierLugarExpedicion != b.ssSupplierLugarExpedicion) return false;
if (a.ssSupplierNr != b.ssSupplierNr) return false;
if (a.ssSupplierRFC != b.ssSupplierRFC) return false;
if (a.ssSupplierSociety != b.ssSupplierSociety) return false;
if (a.ssIsAnticipoWithoutInv != b.ssIsAnticipoWithoutInv) return false;
if (a.ssIsAnticipoWithInv != b.ssIsAnticipoWithInv) return false;
if (a.ssInvoiceUsageKeyList != b.ssInvoiceUsageKeyList) return false;
return true;
}

public static bool operator != (ST_452088c4ad7c6718df20290248661783Structure a, ST_452088c4ad7c6718df20290248661783Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_452088c4ad7c6718df20290248661783Structure)) return false;
return (this == (ST_452088c4ad7c6718df20290248661783Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCostCenterId.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssProject.GetHashCode()
 ^ ssPaymentMethodId.GetHashCode()
 ^ ssPaymentTermsId.GetHashCode()
 ^ ssRegionFI.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssSupplierIsForeigner.GetHashCode()
 ^ ssSupplierLugarExpedicion.GetHashCode()
 ^ ssSupplierNr.GetHashCode()
 ^ ssSupplierRFC.GetHashCode()
 ^ ssSupplierSociety.GetHashCode()
 ^ ssIsAnticipoWithoutInv.GetHashCode()
 ^ ssIsAnticipoWithInv.GetHashCode()
 ^ ssInvoiceUsageKeyList.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssInvoiceUsageKeyList.RecursiveReset();
}

public void InternalRecursiveSave() {
ssInvoiceUsageKeyList.InternalRecursiveSave();
}


public ST_452088c4ad7c6718df20290248661783Structure Duplicate() {
ST_452088c4ad7c6718df20290248661783Structure t;
t.ssCostCenterId = this.ssCostCenterId;
t.ssCurrency = this.ssCurrency;
t.ssProject = this.ssProject;
t.ssPaymentMethodId = this.ssPaymentMethodId;
t.ssPaymentTermsId = this.ssPaymentTermsId;
t.ssRegionFI = this.ssRegionFI;
t.ssTotalAmount = this.ssTotalAmount;
t.ssSupplierIsForeigner = this.ssSupplierIsForeigner;
t.ssSupplierLugarExpedicion = this.ssSupplierLugarExpedicion;
t.ssSupplierNr = this.ssSupplierNr;
t.ssSupplierRFC = this.ssSupplierRFC;
t.ssSupplierSociety = this.ssSupplierSociety;
t.ssIsAnticipoWithoutInv = this.ssIsAnticipoWithoutInv;
t.ssIsAnticipoWithInv = this.ssIsAnticipoWithInv;
t.ssInvoiceUsageKeyList = (BasicTypeList<string>)this.ssInvoiceUsageKeyList.Duplicate();
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
if (head == "costcenterid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterId")) variable.Value = ssCostCenterId; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "project") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project")) variable.Value = ssProject; else variable.Optimized = true;
} else if (head == "paymentmethodid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethodId")) variable.Value = ssPaymentMethodId; else variable.Optimized = true;
} else if (head == "paymenttermsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTermsId")) variable.Value = ssPaymentTermsId; else variable.Optimized = true;
} else if (head == "regionfi") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionFI")) variable.Value = ssRegionFI; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "supplierisforeigner") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierIsForeigner")) variable.Value = ssSupplierIsForeigner; else variable.Optimized = true;
} else if (head == "supplierlugarexpedicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierLugarExpedicion")) variable.Value = ssSupplierLugarExpedicion; else variable.Optimized = true;
} else if (head == "suppliernr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNr")) variable.Value = ssSupplierNr; else variable.Optimized = true;
} else if (head == "supplierrfc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierRFC")) variable.Value = ssSupplierRFC; else variable.Optimized = true;
} else if (head == "suppliersociety") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierSociety")) variable.Value = ssSupplierSociety; else variable.Optimized = true;
} else if (head == "isanticipowithoutinv") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAnticipoWithoutInv")) variable.Value = ssIsAnticipoWithoutInv; else variable.Optimized = true;
} else if (head == "isanticipowithinv") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAnticipoWithInv")) variable.Value = ssIsAnticipoWithInv; else variable.Optimized = true;
} else if (head == "invoiceusagekeylist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUsageKeyList")) variable.Value = ssInvoiceUsageKeyList; else variable.Optimized = true;
variable.SetFieldName("invoiceusagekeylist");
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
if (key == IdCostCenterId) {
return ssCostCenterId;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdProject) {
return ssProject;
}
if (key == IdPaymentMethodId) {
return ssPaymentMethodId;
}
if (key == IdPaymentTermsId) {
return ssPaymentTermsId;
}
if (key == IdRegionFI) {
return ssRegionFI;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdSupplierIsForeigner) {
return ssSupplierIsForeigner;
}
if (key == IdSupplierLugarExpedicion) {
return ssSupplierLugarExpedicion;
}
if (key == IdSupplierNr) {
return ssSupplierNr;
}
if (key == IdSupplierRFC) {
return ssSupplierRFC;
}
if (key == IdSupplierSociety) {
return ssSupplierSociety;
}
if (key == IdIsAnticipoWithoutInv) {
return ssIsAnticipoWithoutInv;
}
if (key == IdIsAnticipoWithInv) {
return ssIsAnticipoWithInv;
}
if (key == IdInvoiceUsageKeyList) {
return ssInvoiceUsageKeyList;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCostCenterId.Key.AsGuid) {
return ssCostCenterId;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdProject.Key.AsGuid) {
return ssProject;
}
if (attributeKey == IdPaymentMethodId.Key.AsGuid) {
return ssPaymentMethodId;
}
if (attributeKey == IdPaymentTermsId.Key.AsGuid) {
return ssPaymentTermsId;
}
if (attributeKey == IdRegionFI.Key.AsGuid) {
return ssRegionFI;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdSupplierIsForeigner.Key.AsGuid) {
return ssSupplierIsForeigner;
}
if (attributeKey == IdSupplierLugarExpedicion.Key.AsGuid) {
return ssSupplierLugarExpedicion;
}
if (attributeKey == IdSupplierNr.Key.AsGuid) {
return ssSupplierNr;
}
if (attributeKey == IdSupplierRFC.Key.AsGuid) {
return ssSupplierRFC;
}
if (attributeKey == IdSupplierSociety.Key.AsGuid) {
return ssSupplierSociety;
}
if (attributeKey == IdIsAnticipoWithoutInv.Key.AsGuid) {
return ssIsAnticipoWithoutInv;
}
if (attributeKey == IdIsAnticipoWithInv.Key.AsGuid) {
return ssIsAnticipoWithInv;
}
if (attributeKey == IdInvoiceUsageKeyList.Key.AsGuid) {
return ssInvoiceUsageKeyList;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCostCenterId = (long) other.AttributeGet(IdCostCenterId);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssProject = (string) other.AttributeGet(IdProject);
ssPaymentMethodId = (long) other.AttributeGet(IdPaymentMethodId);
ssPaymentTermsId = (long) other.AttributeGet(IdPaymentTermsId);
ssRegionFI = (string) other.AttributeGet(IdRegionFI);
ssTotalAmount = (string) other.AttributeGet(IdTotalAmount);
ssSupplierIsForeigner = (bool) other.AttributeGet(IdSupplierIsForeigner);
ssSupplierLugarExpedicion = (string) other.AttributeGet(IdSupplierLugarExpedicion);
ssSupplierNr = (string) other.AttributeGet(IdSupplierNr);
ssSupplierRFC = (string) other.AttributeGet(IdSupplierRFC);
ssSupplierSociety = (string) other.AttributeGet(IdSupplierSociety);
ssIsAnticipoWithoutInv = (bool) other.AttributeGet(IdIsAnticipoWithoutInv);
ssIsAnticipoWithInv = (bool) other.AttributeGet(IdIsAnticipoWithInv);
ssInvoiceUsageKeyList = new BasicTypeList<string>();
ssInvoiceUsageKeyList.FillFromOther((IOSList) other.AttributeGet(IdInvoiceUsageKeyList));
}
} // ST_452088c4ad7c6718df20290248661783Structure
/// <summary>
/// RecordList type <code>UploadValidationDataList</code> that represents a record list of
///  <code>UploadValidationData</code>
/// </summary>
public partial class RL_864246e0e80e8f0b7719c1906203b45e : GenericRecordList<ST_452088c4ad7c6718df20290248661783Structure>, IEnumerable, IEnumerator {

protected override ST_452088c4ad7c6718df20290248661783Structure GetElementDefaultValue() {
return new ST_452088c4ad7c6718df20290248661783Structure();
}

public T[] ToArray<T>(Func<ST_452088c4ad7c6718df20290248661783Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_864246e0e80e8f0b7719c1906203b45e recordList, Func<ST_452088c4ad7c6718df20290248661783Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_864246e0e80e8f0b7719c1906203b45e(ST_452088c4ad7c6718df20290248661783Structure[] array) {
  RL_864246e0e80e8f0b7719c1906203b45e result = new RL_864246e0e80e8f0b7719c1906203b45e();
result.InnerFromArray(array);
    return result;
}

public static RL_864246e0e80e8f0b7719c1906203b45e ToList<T>(T[] array, Func <T, ST_452088c4ad7c6718df20290248661783Structure> converter) {
  RL_864246e0e80e8f0b7719c1906203b45e result = new RL_864246e0e80e8f0b7719c1906203b45e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_864246e0e80e8f0b7719c1906203b45e FromRestList<T>(RestList<T> restList, Func <T, ST_452088c4ad7c6718df20290248661783Structure> converter) {
  RL_864246e0e80e8f0b7719c1906203b45e result = new RL_864246e0e80e8f0b7719c1906203b45e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_864246e0e80e8f0b7719c1906203b45e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_452088c4ad7c6718df20290248661783Structure> NewList() {
return new RL_864246e0e80e8f0b7719c1906203b45e();
}


} // RL_864246e0e80e8f0b7719c1906203b45e
}

