namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (F4uaFZUjBEKCKTQ9uSDplg)
///  <code>RC_7ec02fc4f43bb6e10050644c8c1ae31b</code> that represent
/// s <code>ApprovalProcessLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessLevelRecord
public partial struct RC_7ec02fc4f43bb6e10050644c8c1ae31b : ITypedRecord<RC_7ec02fc4f43bb6e10050644c8c1ae31b> {
internal static readonly GlobalObjectKey IdApprovalProcessLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xC_Afjv04bYAUGRMjBrjGw");

public EN_1d28318723f39133c60733b3cce8955eEntityRecord ssENApprovalProcessLevel;


public static implicit operator EN_1d28318723f39133c60733b3cce8955eEntityRecord( RC_7ec02fc4f43bb6e10050644c8c1ae31b r) {
return r.ssENApprovalProcessLevel;
}

public static implicit operator RC_7ec02fc4f43bb6e10050644c8c1ae31b (EN_1d28318723f39133c60733b3cce8955eEntityRecord r) {
RC_7ec02fc4f43bb6e10050644c8c1ae31b res = new RC_7ec02fc4f43bb6e10050644c8c1ae31b ();
res.ssENApprovalProcessLevel = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENApprovalProcessLevel.ChangedAttributes = value;
}
get {
    return ssENApprovalProcessLevel.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_7ec02fc4f43bb6e10050644c8c1ae31b() {
OptimizedAttributes = null;
ssENApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(26,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcessLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENApprovalProcessLevel.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENApprovalProcessLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprovalProcessLevel.Read( r, ref index);
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
public void ReadIM(RC_7ec02fc4f43bb6e10050644c8c1ae31b r) {
this = r;
}


public static bool operator == (RC_7ec02fc4f43bb6e10050644c8c1ae31b a, RC_7ec02fc4f43bb6e10050644c8c1ae31b b) {
if (a.ssENApprovalProcessLevel != b.ssENApprovalProcessLevel) return false;
return true;
}

public static bool operator != (RC_7ec02fc4f43bb6e10050644c8c1ae31b a, RC_7ec02fc4f43bb6e10050644c8c1ae31b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7ec02fc4f43bb6e10050644c8c1ae31b)) return false;
return (this == (RC_7ec02fc4f43bb6e10050644c8c1ae31b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcessLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcessLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcessLevel.InternalRecursiveSave();
}


public RC_7ec02fc4f43bb6e10050644c8c1ae31b Duplicate() {
RC_7ec02fc4f43bb6e10050644c8c1ae31b t;
t.ssENApprovalProcessLevel = (EN_1d28318723f39133c60733b3cce8955eEntityRecord)this.ssENApprovalProcessLevel.Duplicate();
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
if (head == "approvalprocesslevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessLevel")) variable.Value = ssENApprovalProcessLevel; else variable.Optimized = true;
variable.SetFieldName("approvalprocesslevel");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalProcessLevel.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalProcessLevel.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdApprovalProcessLevel) {
return ssENApprovalProcessLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcessLevel.Key.AsGuid) {
return ssENApprovalProcessLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcessLevel.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessLevel));
}
} // RC_7ec02fc4f43bb6e10050644c8c1ae31b
/// <summary>
/// RecordList type <code>ApprovalProcessLevelRecordList</code> that represents a record list of
///  <code>ApprovalProcessLevel</code>
/// </summary>
public partial class RL_2756368632723623f4eb04ac9a3cb6b6 : GenericRecordList<RC_7ec02fc4f43bb6e10050644c8c1ae31b>, IEnumerable, IEnumerator {

protected override RC_7ec02fc4f43bb6e10050644c8c1ae31b GetElementDefaultValue() {
return new RC_7ec02fc4f43bb6e10050644c8c1ae31b();
}

public T[] ToArray<T>(Func<RC_7ec02fc4f43bb6e10050644c8c1ae31b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2756368632723623f4eb04ac9a3cb6b6 recordList, Func<RC_7ec02fc4f43bb6e10050644c8c1ae31b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2756368632723623f4eb04ac9a3cb6b6(RC_7ec02fc4f43bb6e10050644c8c1ae31b[] array) {
  RL_2756368632723623f4eb04ac9a3cb6b6 result = new RL_2756368632723623f4eb04ac9a3cb6b6();
result.InnerFromArray(array);
    return result;
}

public static RL_2756368632723623f4eb04ac9a3cb6b6 ToList<T>(T[] array, Func <T, RC_7ec02fc4f43bb6e10050644c8c1ae31b> converter) {
  RL_2756368632723623f4eb04ac9a3cb6b6 result = new RL_2756368632723623f4eb04ac9a3cb6b6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2756368632723623f4eb04ac9a3cb6b6 FromRestList<T>(RestList<T> restList, Func <T, RC_7ec02fc4f43bb6e10050644c8c1ae31b> converter) {
  RL_2756368632723623f4eb04ac9a3cb6b6 result = new RL_2756368632723623f4eb04ac9a3cb6b6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2756368632723623f4eb04ac9a3cb6b6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(26,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7ec02fc4f43bb6e10050644c8c1ae31b> NewList() {
return new RL_2756368632723623f4eb04ac9a3cb6b6();
}


} // RL_2756368632723623f4eb04ac9a3cb6b6
}

