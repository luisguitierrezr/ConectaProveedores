namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (MnrPvRGrJU66rtjU0gQPEQ)
///  <code>RC_5e94710ba0de64845af2f9d1cc088302</code> that represents <code>ApprovalStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ApprovalStatusRecord
public partial struct RC_5e94710ba0de64845af2f9d1cc088302 : ITypedRecord<RC_5e94710ba0de64845af2f9d1cc088302> {
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;


public static implicit operator EN_e97ac0d21205ff90ab42100bba6097baEntityRecord( RC_5e94710ba0de64845af2f9d1cc088302 r) {
return r.ssENApprovalStatus;
}

public static implicit operator RC_5e94710ba0de64845af2f9d1cc088302 (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord r) {
RC_5e94710ba0de64845af2f9d1cc088302 res = new RC_5e94710ba0de64845af2f9d1cc088302 ();
res.ssENApprovalStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENApprovalStatus.ChangedAttributes = value;
}
get {
    return ssENApprovalStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5e94710ba0de64845af2f9d1cc088302() {
OptimizedAttributes = null;
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENApprovalStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENApprovalStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprovalStatus.Read( r, ref index);
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
public void ReadIM(RC_5e94710ba0de64845af2f9d1cc088302 r) {
this = r;
}


public static bool operator == (RC_5e94710ba0de64845af2f9d1cc088302 a, RC_5e94710ba0de64845af2f9d1cc088302 b) {
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
return true;
}

public static bool operator != (RC_5e94710ba0de64845af2f9d1cc088302 a, RC_5e94710ba0de64845af2f9d1cc088302 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5e94710ba0de64845af2f9d1cc088302)) return false;
return (this == (RC_5e94710ba0de64845af2f9d1cc088302)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalStatus.InternalRecursiveSave();
}


public RC_5e94710ba0de64845af2f9d1cc088302 Duplicate() {
RC_5e94710ba0de64845af2f9d1cc088302 t;
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
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
if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdApprovalStatus) {
return ssENApprovalStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssENApprovalStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
}
} // RC_5e94710ba0de64845af2f9d1cc088302
/// <summary>
/// RecordList type <code>ApprovalStatusRecordList</code> that represents a record list of
///  <code>ApprovalStatus</code>
/// </summary>
public partial class RL_51a4e63e168a01408e3f55c611518e13 : GenericRecordList<RC_5e94710ba0de64845af2f9d1cc088302>, IEnumerable, IEnumerator {

protected override RC_5e94710ba0de64845af2f9d1cc088302 GetElementDefaultValue() {
return new RC_5e94710ba0de64845af2f9d1cc088302();
}

public T[] ToArray<T>(Func<RC_5e94710ba0de64845af2f9d1cc088302, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_51a4e63e168a01408e3f55c611518e13 recordList, Func<RC_5e94710ba0de64845af2f9d1cc088302, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_51a4e63e168a01408e3f55c611518e13(RC_5e94710ba0de64845af2f9d1cc088302[] array) {
  RL_51a4e63e168a01408e3f55c611518e13 result = new RL_51a4e63e168a01408e3f55c611518e13();
result.InnerFromArray(array);
    return result;
}

public static RL_51a4e63e168a01408e3f55c611518e13 ToList<T>(T[] array, Func <T, RC_5e94710ba0de64845af2f9d1cc088302> converter) {
  RL_51a4e63e168a01408e3f55c611518e13 result = new RL_51a4e63e168a01408e3f55c611518e13();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_51a4e63e168a01408e3f55c611518e13 FromRestList<T>(RestList<T> restList, Func <T, RC_5e94710ba0de64845af2f9d1cc088302> converter) {
  RL_51a4e63e168a01408e3f55c611518e13 result = new RL_51a4e63e168a01408e3f55c611518e13();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_51a4e63e168a01408e3f55c611518e13() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5e94710ba0de64845af2f9d1cc088302> NewList() {
return new RL_51a4e63e168a01408e3f55c611518e13();
}


} // RL_51a4e63e168a01408e3f55c611518e13
}

