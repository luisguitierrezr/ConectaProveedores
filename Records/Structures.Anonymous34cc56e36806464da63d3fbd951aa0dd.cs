namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (41bMNAZoTUamPT+9lRqg3Q)
///  <code>RC_b9271cf96626bd0e3a973b83f0436fc1</code> that represent
/// s <code>RequisitionCompanySupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionCompanySupplierRegionRecord
public partial struct RC_b9271cf96626bd0e3a973b83f0436fc1 : ITypedRecord<RC_b9271cf96626bd0e3a973b83f0436fc1> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_b9271cf96626bd0e3a973b83f0436fc1() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(11,false);
    all[2] = new BitArray(28,false);
    all[3] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENCompany.OptimizedAttributes = value[1];
    ssENSupplier.OptimizedAttributes = value[2];
    ssENRegion.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENCompany.OptimizedAttributes;
    all[2] = ssENSupplier.OptimizedAttributes;
    all[3] = ssENRegion.OptimizedAttributes;
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
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_b9271cf96626bd0e3a973b83f0436fc1 r) {
this = r;
}


public static bool operator == (RC_b9271cf96626bd0e3a973b83f0436fc1 a, RC_b9271cf96626bd0e3a973b83f0436fc1 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_b9271cf96626bd0e3a973b83f0436fc1 a, RC_b9271cf96626bd0e3a973b83f0436fc1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b9271cf96626bd0e3a973b83f0436fc1)) return false;
return (this == (RC_b9271cf96626bd0e3a973b83f0436fc1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_b9271cf96626bd0e3a973b83f0436fc1 Duplicate() {
RC_b9271cf96626bd0e3a973b83f0436fc1 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_b9271cf96626bd0e3a973b83f0436fc1
/// <summary>
/// RecordList type <code>RequisitionCompanySupplierRegionRecordList</code> that represents a record
///  list of <code>Requisition, Company, Supplier, Region</code>
/// </summary>
public partial class RL_1d7ef2a250417492ea51e18cdf076639 : GenericRecordList<RC_b9271cf96626bd0e3a973b83f0436fc1>, IEnumerable, IEnumerator {

protected override RC_b9271cf96626bd0e3a973b83f0436fc1 GetElementDefaultValue() {
return new RC_b9271cf96626bd0e3a973b83f0436fc1();
}

public T[] ToArray<T>(Func<RC_b9271cf96626bd0e3a973b83f0436fc1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1d7ef2a250417492ea51e18cdf076639 recordList, Func<RC_b9271cf96626bd0e3a973b83f0436fc1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1d7ef2a250417492ea51e18cdf076639(RC_b9271cf96626bd0e3a973b83f0436fc1[] array) {
  RL_1d7ef2a250417492ea51e18cdf076639 result = new RL_1d7ef2a250417492ea51e18cdf076639();
result.InnerFromArray(array);
    return result;
}

public static RL_1d7ef2a250417492ea51e18cdf076639 ToList<T>(T[] array, Func <T, RC_b9271cf96626bd0e3a973b83f0436fc1> converter) {
  RL_1d7ef2a250417492ea51e18cdf076639 result = new RL_1d7ef2a250417492ea51e18cdf076639();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1d7ef2a250417492ea51e18cdf076639 FromRestList<T>(RestList<T> restList, Func <T, RC_b9271cf96626bd0e3a973b83f0436fc1> converter) {
  RL_1d7ef2a250417492ea51e18cdf076639 result = new RL_1d7ef2a250417492ea51e18cdf076639();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1d7ef2a250417492ea51e18cdf076639() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(58,false);
def[1] = new BitArray(11,false);
def[2] = new BitArray(28,false);
def[3] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b9271cf96626bd0e3a973b83f0436fc1> NewList() {
return new RL_1d7ef2a250417492ea51e18cdf076639();
}


} // RL_1d7ef2a250417492ea51e18cdf076639
}

