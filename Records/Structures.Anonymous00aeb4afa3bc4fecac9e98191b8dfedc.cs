namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (r7SuALyj7E+snpgZG43+3A)
///  <code>RC_b64650646295f01a3e7c46ac44009d3c</code> that represent
/// s
///  <code>InvoiceInvoiceExtendedTaxInvoiceTaxTypeRequisitionInvoiceExtendedDistributionFrequencyProject
/// _Asset_ServiceBusinessValueCategoryBusinessValueSubcategoryRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceExtendedTaxInvoiceTaxTypeRequisitionInvoiceExtendedDistributionFrequencyProject_Asset_ServiceBusinessValueCategoryBusinessValueSubcategoryRecord
public partial struct RC_b64650646295f01a3e7c46ac44009d3c : ITypedRecord<RC_b64650646295f01a3e7c46ac44009d3c> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceExtendedTax = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rxJZlscwt_sxbxe_jjMXgg");
internal static readonly GlobalObjectKey IdInvoiceTaxType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Pp75aInYO24kGr6Sy7bJsA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");
internal static readonly GlobalObjectKey IdDistribution = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CCJIpkzC5uLJxroW5XsBhQ");
internal static readonly GlobalObjectKey IdFrequency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2AnG8vhYHkF1++3uYMXd3w");
internal static readonly GlobalObjectKey IdProject_Asset_Service = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*waIIG87O4_GzAGpguX_Gjg");
internal static readonly GlobalObjectKey IdBusinessValueCategory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Cy44yO4IWZ1l5arlsX1iYQ");
internal static readonly GlobalObjectKey IdBusinessValueSubcategory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Pgajh3RmSwFLNF3OIf9NhA");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord ssENInvoiceExtendedTax;

public EN_cff5cb02ac5fe11578884acf37327af3EntityRecord ssENInvoiceTaxType;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;

public EN_88460e7eac2a65d244abb23fe44af0adEntityRecord ssENDistribution;

public EN_a6239c65aa61ed4530d18a92034301bbEntityRecord ssENFrequency;

public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord ssENProject_Asset_Service;

public EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord ssENBusinessValueCategory;

public EN_f296fc330d9916f9de4aae18321e8388EntityRecord ssENBusinessValueSubcategory;


public BitArray OptimizedAttributes;

public RC_b64650646295f01a3e7c46ac44009d3c() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceExtendedTax = new EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord();
ssENInvoiceTaxType = new EN_cff5cb02ac5fe11578884acf37327af3EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
ssENDistribution = new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord();
ssENFrequency = new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord();
ssENProject_Asset_Service = new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
ssENBusinessValueCategory = new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord();
ssENBusinessValueSubcategory = new EN_f296fc330d9916f9de4aae18321e8388EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[10];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(4,false);
    all[3] = new BitArray(58,false);
    all[4] = new BitArray(19,false);
    all[5] = new BitArray(4,false);
    all[6] = new BitArray(4,false);
    all[7] = new BitArray(7,false);
    all[8] = new BitArray(6,false);
    all[9] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceExtendedTax.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceTaxType.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENDistribution.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENFrequency.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENProject_Asset_Service.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENBusinessValueCategory.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENBusinessValueSubcategory.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceExtendedTax.OptimizedAttributes = value[1];
    ssENInvoiceTaxType.OptimizedAttributes = value[2];
    ssENRequisition.OptimizedAttributes = value[3];
    ssENInvoiceExtended.OptimizedAttributes = value[4];
    ssENDistribution.OptimizedAttributes = value[5];
    ssENFrequency.OptimizedAttributes = value[6];
    ssENProject_Asset_Service.OptimizedAttributes = value[7];
    ssENBusinessValueCategory.OptimizedAttributes = value[8];
    ssENBusinessValueSubcategory.OptimizedAttributes = value[9];
    }
}
get{
    BitArray[] all = new BitArray[10];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceExtendedTax.OptimizedAttributes;
    all[2] = ssENInvoiceTaxType.OptimizedAttributes;
    all[3] = ssENRequisition.OptimizedAttributes;
    all[4] = ssENInvoiceExtended.OptimizedAttributes;
    all[5] = ssENDistribution.OptimizedAttributes;
    all[6] = ssENFrequency.OptimizedAttributes;
    all[7] = ssENProject_Asset_Service.OptimizedAttributes;
    all[8] = ssENBusinessValueCategory.OptimizedAttributes;
    all[9] = ssENBusinessValueSubcategory.OptimizedAttributes;
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
ssENInvoiceExtendedTax.Read( r, ref index);
ssENInvoiceTaxType.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
ssENDistribution.Read( r, ref index);
ssENFrequency.Read( r, ref index);
ssENProject_Asset_Service.Read( r, ref index);
ssENBusinessValueCategory.Read( r, ref index);
ssENBusinessValueSubcategory.Read( r, ref index);
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
public void ReadIM(RC_b64650646295f01a3e7c46ac44009d3c r) {
this = r;
}


public static bool operator == (RC_b64650646295f01a3e7c46ac44009d3c a, RC_b64650646295f01a3e7c46ac44009d3c b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceExtendedTax != b.ssENInvoiceExtendedTax) return false;
if (a.ssENInvoiceTaxType != b.ssENInvoiceTaxType) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
if (a.ssENDistribution != b.ssENDistribution) return false;
if (a.ssENFrequency != b.ssENFrequency) return false;
if (a.ssENProject_Asset_Service != b.ssENProject_Asset_Service) return false;
if (a.ssENBusinessValueCategory != b.ssENBusinessValueCategory) return false;
if (a.ssENBusinessValueSubcategory != b.ssENBusinessValueSubcategory) return false;
return true;
}

public static bool operator != (RC_b64650646295f01a3e7c46ac44009d3c a, RC_b64650646295f01a3e7c46ac44009d3c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b64650646295f01a3e7c46ac44009d3c)) return false;
return (this == (RC_b64650646295f01a3e7c46ac44009d3c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceExtendedTax.GetHashCode()
 ^ ssENInvoiceTaxType.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
 ^ ssENDistribution.GetHashCode()
 ^ ssENFrequency.GetHashCode()
 ^ ssENProject_Asset_Service.GetHashCode()
 ^ ssENBusinessValueCategory.GetHashCode()
 ^ ssENBusinessValueSubcategory.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceExtendedTax.RecursiveReset();
ssENInvoiceTaxType.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
ssENDistribution.RecursiveReset();
ssENFrequency.RecursiveReset();
ssENProject_Asset_Service.RecursiveReset();
ssENBusinessValueCategory.RecursiveReset();
ssENBusinessValueSubcategory.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceExtendedTax.InternalRecursiveSave();
ssENInvoiceTaxType.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
ssENDistribution.InternalRecursiveSave();
ssENFrequency.InternalRecursiveSave();
ssENProject_Asset_Service.InternalRecursiveSave();
ssENBusinessValueCategory.InternalRecursiveSave();
ssENBusinessValueSubcategory.InternalRecursiveSave();
}


public RC_b64650646295f01a3e7c46ac44009d3c Duplicate() {
RC_b64650646295f01a3e7c46ac44009d3c t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceExtendedTax = (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord)this.ssENInvoiceExtendedTax.Duplicate();
t.ssENInvoiceTaxType = (EN_cff5cb02ac5fe11578884acf37327af3EntityRecord)this.ssENInvoiceTaxType.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
t.ssENDistribution = (EN_88460e7eac2a65d244abb23fe44af0adEntityRecord)this.ssENDistribution.Duplicate();
t.ssENFrequency = (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord)this.ssENFrequency.Duplicate();
t.ssENProject_Asset_Service = (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord)this.ssENProject_Asset_Service.Duplicate();
t.ssENBusinessValueCategory = (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord)this.ssENBusinessValueCategory.Duplicate();
t.ssENBusinessValueSubcategory = (EN_f296fc330d9916f9de4aae18321e8388EntityRecord)this.ssENBusinessValueSubcategory.Duplicate();
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
} else if (head == "invoiceextendedtax") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedTax")) variable.Value = ssENInvoiceExtendedTax; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedtax");
} else if (head == "invoicetaxtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceTaxType")) variable.Value = ssENInvoiceTaxType; else variable.Optimized = true;
variable.SetFieldName("invoicetaxtype");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
} else if (head == "distribution") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Distribution")) variable.Value = ssENDistribution; else variable.Optimized = true;
variable.SetFieldName("distribution");
} else if (head == "frequency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Frequency")) variable.Value = ssENFrequency; else variable.Optimized = true;
variable.SetFieldName("frequency");
} else if (head == "project_asset_service") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project_Asset_Service")) variable.Value = ssENProject_Asset_Service; else variable.Optimized = true;
variable.SetFieldName("project_asset_service");
} else if (head == "businessvaluecategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueCategory")) variable.Value = ssENBusinessValueCategory; else variable.Optimized = true;
variable.SetFieldName("businessvaluecategory");
} else if (head == "businessvaluesubcategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueSubcategory")) variable.Value = ssENBusinessValueSubcategory; else variable.Optimized = true;
variable.SetFieldName("businessvaluesubcategory");
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
if (key == IdInvoiceExtendedTax) {
return ssENInvoiceExtendedTax;
}
if (key == IdInvoiceTaxType) {
return ssENInvoiceTaxType;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
if (key == IdDistribution) {
return ssENDistribution;
}
if (key == IdFrequency) {
return ssENFrequency;
}
if (key == IdProject_Asset_Service) {
return ssENProject_Asset_Service;
}
if (key == IdBusinessValueCategory) {
return ssENBusinessValueCategory;
}
if (key == IdBusinessValueSubcategory) {
return ssENBusinessValueSubcategory;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceExtendedTax.Key.AsGuid) {
return ssENInvoiceExtendedTax;
}
if (attributeKey == IdInvoiceTaxType.Key.AsGuid) {
return ssENInvoiceTaxType;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
if (attributeKey == IdDistribution.Key.AsGuid) {
return ssENDistribution;
}
if (attributeKey == IdFrequency.Key.AsGuid) {
return ssENFrequency;
}
if (attributeKey == IdProject_Asset_Service.Key.AsGuid) {
return ssENProject_Asset_Service;
}
if (attributeKey == IdBusinessValueCategory.Key.AsGuid) {
return ssENBusinessValueCategory;
}
if (attributeKey == IdBusinessValueSubcategory.Key.AsGuid) {
return ssENBusinessValueSubcategory;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceExtendedTax.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedTax));
ssENInvoiceTaxType.FillFromOther((IRecord) other.AttributeGet(IdInvoiceTaxType));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
ssENDistribution.FillFromOther((IRecord) other.AttributeGet(IdDistribution));
ssENFrequency.FillFromOther((IRecord) other.AttributeGet(IdFrequency));
ssENProject_Asset_Service.FillFromOther((IRecord) other.AttributeGet(IdProject_Asset_Service));
ssENBusinessValueCategory.FillFromOther((IRecord) other.AttributeGet(IdBusinessValueCategory));
ssENBusinessValueSubcategory.FillFromOther((IRecord) other.AttributeGet(IdBusinessValueSubcategory));
}
} // RC_b64650646295f01a3e7c46ac44009d3c
/// <summary>
/// RecordList type
///  <code>InvoiceInvoiceExtendedTaxInvoiceTaxTypeRequisitionInvoiceExtendedDistributionFrequencyProject
/// _Asset_ServiceBusinessValueCategoryBusinessValueSubcategoryRecordList</code> that represents a
///  record list of <code>Invoice, InvoiceExtendedTax, InvoiceTaxType, Requisition, InvoiceExtended
/// , Distribution, Frequency, Project_Asset_Service, BusinessValueCategory,
///  BusinessValueSubcategory</code>
/// </summary>
public partial class RL_555a5d0da2fe2f0e71754918f879d5c3 : GenericRecordList<RC_b64650646295f01a3e7c46ac44009d3c>, IEnumerable, IEnumerator {

protected override RC_b64650646295f01a3e7c46ac44009d3c GetElementDefaultValue() {
return new RC_b64650646295f01a3e7c46ac44009d3c();
}

public T[] ToArray<T>(Func<RC_b64650646295f01a3e7c46ac44009d3c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_555a5d0da2fe2f0e71754918f879d5c3 recordList, Func<RC_b64650646295f01a3e7c46ac44009d3c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_555a5d0da2fe2f0e71754918f879d5c3(RC_b64650646295f01a3e7c46ac44009d3c[] array) {
  RL_555a5d0da2fe2f0e71754918f879d5c3 result = new RL_555a5d0da2fe2f0e71754918f879d5c3();
result.InnerFromArray(array);
    return result;
}

public static RL_555a5d0da2fe2f0e71754918f879d5c3 ToList<T>(T[] array, Func <T, RC_b64650646295f01a3e7c46ac44009d3c> converter) {
  RL_555a5d0da2fe2f0e71754918f879d5c3 result = new RL_555a5d0da2fe2f0e71754918f879d5c3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_555a5d0da2fe2f0e71754918f879d5c3 FromRestList<T>(RestList<T> restList, Func <T, RC_b64650646295f01a3e7c46ac44009d3c> converter) {
  RL_555a5d0da2fe2f0e71754918f879d5c3 result = new RL_555a5d0da2fe2f0e71754918f879d5c3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_555a5d0da2fe2f0e71754918f879d5c3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[10];
def[0] = new BitArray(24,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(4,false);
def[3] = new BitArray(58,false);
def[4] = new BitArray(19,false);
def[5] = new BitArray(4,false);
def[6] = new BitArray(4,false);
def[7] = new BitArray(7,false);
def[8] = new BitArray(6,false);
def[9] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b64650646295f01a3e7c46ac44009d3c> NewList() {
return new RL_555a5d0da2fe2f0e71754918f879d5c3();
}


} // RL_555a5d0da2fe2f0e71754918f879d5c3
}

