namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (AbJeQAsHukWmUCITA8_xSg)
///  <code>RC_c72f9a44b3b624f179aa49efc0650682</code> that represent
/// s <code>FolioApprovalProcessTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalProcessTypeRecord
public partial struct RC_c72f9a44b3b624f179aa49efc0650682 : ITypedRecord<RC_c72f9a44b3b624f179aa49efc0650682> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdApprovalProcessType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3A7bZn7_sKmqJY4zWt0czA");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord ssENApprovalProcessType;


public BitArray OptimizedAttributes;

public RC_c72f9a44b3b624f179aa49efc0650682() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENApprovalProcessType = new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENApprovalProcessType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENApprovalProcessType.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENApprovalProcessType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolio.Read( r, ref index);
ssENApprovalProcessType.Read( r, ref index);
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
public void ReadIM(RC_c72f9a44b3b624f179aa49efc0650682 r) {
this = r;
}


public static bool operator == (RC_c72f9a44b3b624f179aa49efc0650682 a, RC_c72f9a44b3b624f179aa49efc0650682 b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENApprovalProcessType != b.ssENApprovalProcessType) return false;
return true;
}

public static bool operator != (RC_c72f9a44b3b624f179aa49efc0650682 a, RC_c72f9a44b3b624f179aa49efc0650682 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c72f9a44b3b624f179aa49efc0650682)) return false;
return (this == (RC_c72f9a44b3b624f179aa49efc0650682)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENApprovalProcessType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENApprovalProcessType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENApprovalProcessType.InternalRecursiveSave();
}


public RC_c72f9a44b3b624f179aa49efc0650682 Duplicate() {
RC_c72f9a44b3b624f179aa49efc0650682 t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENApprovalProcessType = (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord)this.ssENApprovalProcessType.Duplicate();
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
if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "approvalprocesstype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessType")) variable.Value = ssENApprovalProcessType; else variable.Optimized = true;
variable.SetFieldName("approvalprocesstype");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdApprovalProcessType) {
return ssENApprovalProcessType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdApprovalProcessType.Key.AsGuid) {
return ssENApprovalProcessType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENApprovalProcessType.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessType));
}
} // RC_c72f9a44b3b624f179aa49efc0650682
/// <summary>
/// RecordList type <code>FolioApprovalProcessTypeRecordList</code> that represents a record list of
///  <code>Folio, ApprovalProcessType</code>
/// </summary>
public partial class RL_2cbca8577d8f7895afb5778093b67b34 : GenericRecordList<RC_c72f9a44b3b624f179aa49efc0650682>, IEnumerable, IEnumerator {

protected override RC_c72f9a44b3b624f179aa49efc0650682 GetElementDefaultValue() {
return new RC_c72f9a44b3b624f179aa49efc0650682();
}

public T[] ToArray<T>(Func<RC_c72f9a44b3b624f179aa49efc0650682, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2cbca8577d8f7895afb5778093b67b34 recordList, Func<RC_c72f9a44b3b624f179aa49efc0650682, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2cbca8577d8f7895afb5778093b67b34(RC_c72f9a44b3b624f179aa49efc0650682[] array) {
  RL_2cbca8577d8f7895afb5778093b67b34 result = new RL_2cbca8577d8f7895afb5778093b67b34();
result.InnerFromArray(array);
    return result;
}

public static RL_2cbca8577d8f7895afb5778093b67b34 ToList<T>(T[] array, Func <T, RC_c72f9a44b3b624f179aa49efc0650682> converter) {
  RL_2cbca8577d8f7895afb5778093b67b34 result = new RL_2cbca8577d8f7895afb5778093b67b34();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2cbca8577d8f7895afb5778093b67b34 FromRestList<T>(RestList<T> restList, Func <T, RC_c72f9a44b3b624f179aa49efc0650682> converter) {
  RL_2cbca8577d8f7895afb5778093b67b34 result = new RL_2cbca8577d8f7895afb5778093b67b34();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2cbca8577d8f7895afb5778093b67b34() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(20,false);
def[1] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c72f9a44b3b624f179aa49efc0650682> NewList() {
return new RL_2cbca8577d8f7895afb5778093b67b34();
}


} // RL_2cbca8577d8f7895afb5778093b67b34
}

