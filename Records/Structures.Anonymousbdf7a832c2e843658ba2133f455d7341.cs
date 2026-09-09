namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Mqj3vejCZUOLohM_RV1zQQ)
///  <code>RC_8f1f5794477fd248ce426e958892e780</code> that represent
/// s
///  <code>RequisitionSupplierFrequencyProject_Asset_ServiceBusinessValueCategoryBusinessValueSubcategor
/// yRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionSupplierFrequencyProject_Asset_ServiceBusinessValueCategoryBusinessValueSubcategoryRecord
public partial struct RC_8f1f5794477fd248ce426e958892e780 : ITypedRecord<RC_8f1f5794477fd248ce426e958892e780> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdFrequency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2AnG8vhYHkF1++3uYMXd3w");
internal static readonly GlobalObjectKey IdProject_Asset_Service = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*waIIG87O4_GzAGpguX_Gjg");
internal static readonly GlobalObjectKey IdBusinessValueCategory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Cy44yO4IWZ1l5arlsX1iYQ");
internal static readonly GlobalObjectKey IdBusinessValueSubcategory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Pgajh3RmSwFLNF3OIf9NhA");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_a6239c65aa61ed4530d18a92034301bbEntityRecord ssENFrequency;

public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord ssENProject_Asset_Service;

public EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord ssENBusinessValueCategory;

public EN_f296fc330d9916f9de4aae18321e8388EntityRecord ssENBusinessValueSubcategory;


public BitArray OptimizedAttributes;

public RC_8f1f5794477fd248ce426e958892e780() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENFrequency = new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord();
ssENProject_Asset_Service = new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
ssENBusinessValueCategory = new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord();
ssENBusinessValueSubcategory = new EN_f296fc330d9916f9de4aae18321e8388EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(28,false);
    all[2] = new BitArray(4,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(6,false);
    all[5] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFrequency.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENProject_Asset_Service.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENBusinessValueCategory.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENBusinessValueSubcategory.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    ssENFrequency.OptimizedAttributes = value[2];
    ssENProject_Asset_Service.OptimizedAttributes = value[3];
    ssENBusinessValueCategory.OptimizedAttributes = value[4];
    ssENBusinessValueSubcategory.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENSupplier.OptimizedAttributes;
    all[2] = ssENFrequency.OptimizedAttributes;
    all[3] = ssENProject_Asset_Service.OptimizedAttributes;
    all[4] = ssENBusinessValueCategory.OptimizedAttributes;
    all[5] = ssENBusinessValueSubcategory.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisition.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_8f1f5794477fd248ce426e958892e780 r) {
this = r;
}


public static bool operator == (RC_8f1f5794477fd248ce426e958892e780 a, RC_8f1f5794477fd248ce426e958892e780 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENFrequency != b.ssENFrequency) return false;
if (a.ssENProject_Asset_Service != b.ssENProject_Asset_Service) return false;
if (a.ssENBusinessValueCategory != b.ssENBusinessValueCategory) return false;
if (a.ssENBusinessValueSubcategory != b.ssENBusinessValueSubcategory) return false;
return true;
}

public static bool operator != (RC_8f1f5794477fd248ce426e958892e780 a, RC_8f1f5794477fd248ce426e958892e780 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8f1f5794477fd248ce426e958892e780)) return false;
return (this == (RC_8f1f5794477fd248ce426e958892e780)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENSupplier.GetHashCode()
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
ssENRequisition.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENFrequency.RecursiveReset();
ssENProject_Asset_Service.RecursiveReset();
ssENBusinessValueCategory.RecursiveReset();
ssENBusinessValueSubcategory.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENFrequency.InternalRecursiveSave();
ssENProject_Asset_Service.InternalRecursiveSave();
ssENBusinessValueCategory.InternalRecursiveSave();
ssENBusinessValueSubcategory.InternalRecursiveSave();
}


public RC_8f1f5794477fd248ce426e958892e780 Duplicate() {
RC_8f1f5794477fd248ce426e958892e780 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdSupplier) {
return ssENSupplier;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
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
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENFrequency.FillFromOther((IRecord) other.AttributeGet(IdFrequency));
ssENProject_Asset_Service.FillFromOther((IRecord) other.AttributeGet(IdProject_Asset_Service));
ssENBusinessValueCategory.FillFromOther((IRecord) other.AttributeGet(IdBusinessValueCategory));
ssENBusinessValueSubcategory.FillFromOther((IRecord) other.AttributeGet(IdBusinessValueSubcategory));
}
} // RC_8f1f5794477fd248ce426e958892e780
/// <summary>
/// RecordList type
///  <code>RequisitionSupplierFrequencyProject_Asset_ServiceBusinessValueCategoryBusinessValueSubcategor
/// yRecordList</code> that represents a record list of <code>Requisition, Supplier, Frequency,
///  Project_Asset_Service, BusinessValueCategory, BusinessValueSubcategory</code>
/// </summary>
public partial class RL_d37c3599312f2bd85c82314399f4e20e : GenericRecordList<RC_8f1f5794477fd248ce426e958892e780>, IEnumerable, IEnumerator {

protected override RC_8f1f5794477fd248ce426e958892e780 GetElementDefaultValue() {
return new RC_8f1f5794477fd248ce426e958892e780();
}

public T[] ToArray<T>(Func<RC_8f1f5794477fd248ce426e958892e780, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d37c3599312f2bd85c82314399f4e20e recordList, Func<RC_8f1f5794477fd248ce426e958892e780, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d37c3599312f2bd85c82314399f4e20e(RC_8f1f5794477fd248ce426e958892e780[] array) {
  RL_d37c3599312f2bd85c82314399f4e20e result = new RL_d37c3599312f2bd85c82314399f4e20e();
result.InnerFromArray(array);
    return result;
}

public static RL_d37c3599312f2bd85c82314399f4e20e ToList<T>(T[] array, Func <T, RC_8f1f5794477fd248ce426e958892e780> converter) {
  RL_d37c3599312f2bd85c82314399f4e20e result = new RL_d37c3599312f2bd85c82314399f4e20e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d37c3599312f2bd85c82314399f4e20e FromRestList<T>(RestList<T> restList, Func <T, RC_8f1f5794477fd248ce426e958892e780> converter) {
  RL_d37c3599312f2bd85c82314399f4e20e result = new RL_d37c3599312f2bd85c82314399f4e20e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d37c3599312f2bd85c82314399f4e20e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(58,false);
def[1] = new BitArray(28,false);
def[2] = new BitArray(4,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(6,false);
def[5] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8f1f5794477fd248ce426e958892e780> NewList() {
return new RL_d37c3599312f2bd85c82314399f4e20e();
}


} // RL_d37c3599312f2bd85c82314399f4e20e
}

