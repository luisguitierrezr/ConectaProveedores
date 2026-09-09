namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (yWjan6yb2Ey9qTT9PQKAEw)
///  <code>RC_40e7a439bb45c9955de25b1debc0650f</code> that represent
/// s <code>ApprovalProcessMatrixRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessMatrixRecord
public partial struct RC_40e7a439bb45c9955de25b1debc0650f : ITypedRecord<RC_40e7a439bb45c9955de25b1debc0650f> {
internal static readonly GlobalObjectKey IdApprovalProcessMatrix = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OaTnQEW7lcld4lsd68BlDw");

public EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord ssENApprovalProcessMatrix;


public static implicit operator EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord( RC_40e7a439bb45c9955de25b1debc0650f r) {
return r.ssENApprovalProcessMatrix;
}

public static implicit operator RC_40e7a439bb45c9955de25b1debc0650f (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord r) {
RC_40e7a439bb45c9955de25b1debc0650f res = new RC_40e7a439bb45c9955de25b1debc0650f ();
res.ssENApprovalProcessMatrix = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENApprovalProcessMatrix.ChangedAttributes = value;
}
get {
    return ssENApprovalProcessMatrix.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_40e7a439bb45c9955de25b1debc0650f() {
OptimizedAttributes = null;
ssENApprovalProcessMatrix = new EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(12,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcessMatrix.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENApprovalProcessMatrix.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENApprovalProcessMatrix.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprovalProcessMatrix.Read( r, ref index);
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
public void ReadIM(RC_40e7a439bb45c9955de25b1debc0650f r) {
this = r;
}


public static bool operator == (RC_40e7a439bb45c9955de25b1debc0650f a, RC_40e7a439bb45c9955de25b1debc0650f b) {
if (a.ssENApprovalProcessMatrix != b.ssENApprovalProcessMatrix) return false;
return true;
}

public static bool operator != (RC_40e7a439bb45c9955de25b1debc0650f a, RC_40e7a439bb45c9955de25b1debc0650f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_40e7a439bb45c9955de25b1debc0650f)) return false;
return (this == (RC_40e7a439bb45c9955de25b1debc0650f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcessMatrix.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcessMatrix.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcessMatrix.InternalRecursiveSave();
}


public RC_40e7a439bb45c9955de25b1debc0650f Duplicate() {
RC_40e7a439bb45c9955de25b1debc0650f t;
t.ssENApprovalProcessMatrix = (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord)this.ssENApprovalProcessMatrix.Duplicate();
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
if (head == "approvalprocessmatrix") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessMatrix")) variable.Value = ssENApprovalProcessMatrix; else variable.Optimized = true;
variable.SetFieldName("approvalprocessmatrix");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalProcessMatrix.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalProcessMatrix.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdApprovalProcessMatrix) {
return ssENApprovalProcessMatrix;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcessMatrix.Key.AsGuid) {
return ssENApprovalProcessMatrix;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcessMatrix.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessMatrix));
}
} // RC_40e7a439bb45c9955de25b1debc0650f
/// <summary>
/// RecordList type <code>ApprovalProcessMatrixRecordList</code> that represents a record list of
///  <code>ApprovalProcessMatrix</code>
/// </summary>
public partial class RL_8dec11fcff240aa1b7ad6531b205e8a4 : GenericRecordList<RC_40e7a439bb45c9955de25b1debc0650f>, IEnumerable, IEnumerator {

protected override RC_40e7a439bb45c9955de25b1debc0650f GetElementDefaultValue() {
return new RC_40e7a439bb45c9955de25b1debc0650f();
}

public T[] ToArray<T>(Func<RC_40e7a439bb45c9955de25b1debc0650f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8dec11fcff240aa1b7ad6531b205e8a4 recordList, Func<RC_40e7a439bb45c9955de25b1debc0650f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8dec11fcff240aa1b7ad6531b205e8a4(RC_40e7a439bb45c9955de25b1debc0650f[] array) {
  RL_8dec11fcff240aa1b7ad6531b205e8a4 result = new RL_8dec11fcff240aa1b7ad6531b205e8a4();
result.InnerFromArray(array);
    return result;
}

public static RL_8dec11fcff240aa1b7ad6531b205e8a4 ToList<T>(T[] array, Func <T, RC_40e7a439bb45c9955de25b1debc0650f> converter) {
  RL_8dec11fcff240aa1b7ad6531b205e8a4 result = new RL_8dec11fcff240aa1b7ad6531b205e8a4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8dec11fcff240aa1b7ad6531b205e8a4 FromRestList<T>(RestList<T> restList, Func <T, RC_40e7a439bb45c9955de25b1debc0650f> converter) {
  RL_8dec11fcff240aa1b7ad6531b205e8a4 result = new RL_8dec11fcff240aa1b7ad6531b205e8a4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8dec11fcff240aa1b7ad6531b205e8a4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(12,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_40e7a439bb45c9955de25b1debc0650f> NewList() {
return new RL_8dec11fcff240aa1b7ad6531b205e8a4();
}


} // RL_8dec11fcff240aa1b7ad6531b205e8a4
}

