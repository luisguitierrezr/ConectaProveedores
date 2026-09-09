namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (xeMAE4QCIEm9d22nzbqbLw)
///  <code>RC_d8083705fb77c898d676210940ce11bd</code> that represent
/// s <code>RequisitionCompanySupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionCompanySupplierRecord
public partial struct RC_d8083705fb77c898d676210940ce11bd : ITypedRecord<RC_d8083705fb77c898d676210940ce11bd> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_d8083705fb77c898d676210940ce11bd() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(11,false);
    all[2] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENCompany.OptimizedAttributes = value[1];
    ssENSupplier.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENCompany.OptimizedAttributes;
    all[2] = ssENSupplier.OptimizedAttributes;
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
public void ReadIM(RC_d8083705fb77c898d676210940ce11bd r) {
this = r;
}


public static bool operator == (RC_d8083705fb77c898d676210940ce11bd a, RC_d8083705fb77c898d676210940ce11bd b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_d8083705fb77c898d676210940ce11bd a, RC_d8083705fb77c898d676210940ce11bd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d8083705fb77c898d676210940ce11bd)) return false;
return (this == (RC_d8083705fb77c898d676210940ce11bd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_d8083705fb77c898d676210940ce11bd Duplicate() {
RC_d8083705fb77c898d676210940ce11bd t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_d8083705fb77c898d676210940ce11bd
/// <summary>
/// RecordList type <code>RequisitionCompanySupplierRecordList</code> that represents a record list of
///  <code>Requisition, Company, Supplier</code>
/// </summary>
public partial class RL_96dd8a4e4f78e65ee5dd5a096dbe2ade : GenericRecordList<RC_d8083705fb77c898d676210940ce11bd>, IEnumerable, IEnumerator {

protected override RC_d8083705fb77c898d676210940ce11bd GetElementDefaultValue() {
return new RC_d8083705fb77c898d676210940ce11bd();
}

public T[] ToArray<T>(Func<RC_d8083705fb77c898d676210940ce11bd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_96dd8a4e4f78e65ee5dd5a096dbe2ade recordList, Func<RC_d8083705fb77c898d676210940ce11bd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_96dd8a4e4f78e65ee5dd5a096dbe2ade(RC_d8083705fb77c898d676210940ce11bd[] array) {
  RL_96dd8a4e4f78e65ee5dd5a096dbe2ade result = new RL_96dd8a4e4f78e65ee5dd5a096dbe2ade();
result.InnerFromArray(array);
    return result;
}

public static RL_96dd8a4e4f78e65ee5dd5a096dbe2ade ToList<T>(T[] array, Func <T, RC_d8083705fb77c898d676210940ce11bd> converter) {
  RL_96dd8a4e4f78e65ee5dd5a096dbe2ade result = new RL_96dd8a4e4f78e65ee5dd5a096dbe2ade();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_96dd8a4e4f78e65ee5dd5a096dbe2ade FromRestList<T>(RestList<T> restList, Func <T, RC_d8083705fb77c898d676210940ce11bd> converter) {
  RL_96dd8a4e4f78e65ee5dd5a096dbe2ade result = new RL_96dd8a4e4f78e65ee5dd5a096dbe2ade();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_96dd8a4e4f78e65ee5dd5a096dbe2ade() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(58,false);
def[1] = new BitArray(11,false);
def[2] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d8083705fb77c898d676210940ce11bd> NewList() {
return new RL_96dd8a4e4f78e65ee5dd5a096dbe2ade();
}


} // RL_96dd8a4e4f78e65ee5dd5a096dbe2ade
}

