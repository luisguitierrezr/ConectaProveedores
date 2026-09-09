namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (vtHiZM3d5U+X2I_heqXKwA)
///  <code>RC_003b51eef272cce91f55924f504b1b11</code> that represent
/// s <code>OrderRequestFileCommentRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileCommentRecord
public partial struct RC_003b51eef272cce91f55924f504b1b11 : ITypedRecord<RC_003b51eef272cce91f55924f504b1b11> {
internal static readonly GlobalObjectKey IdOrderRequestFileComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7lE7AHLy6cwfVZJPUEsbEQ");

public EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord ssENOrderRequestFileComment;


public static implicit operator EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord( RC_003b51eef272cce91f55924f504b1b11 r) {
return r.ssENOrderRequestFileComment;
}

public static implicit operator RC_003b51eef272cce91f55924f504b1b11 (EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord r) {
RC_003b51eef272cce91f55924f504b1b11 res = new RC_003b51eef272cce91f55924f504b1b11 ();
res.ssENOrderRequestFileComment = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderRequestFileComment.ChangedAttributes = value;
}
get {
    return ssENOrderRequestFileComment.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_003b51eef272cce91f55924f504b1b11() {
OptimizedAttributes = null;
ssENOrderRequestFileComment = new EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderRequestFileComment.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderRequestFileComment.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderRequestFileComment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderRequestFileComment.Read( r, ref index);
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
public void ReadIM(RC_003b51eef272cce91f55924f504b1b11 r) {
this = r;
}


public static bool operator == (RC_003b51eef272cce91f55924f504b1b11 a, RC_003b51eef272cce91f55924f504b1b11 b) {
if (a.ssENOrderRequestFileComment != b.ssENOrderRequestFileComment) return false;
return true;
}

public static bool operator != (RC_003b51eef272cce91f55924f504b1b11 a, RC_003b51eef272cce91f55924f504b1b11 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_003b51eef272cce91f55924f504b1b11)) return false;
return (this == (RC_003b51eef272cce91f55924f504b1b11)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderRequestFileComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderRequestFileComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderRequestFileComment.InternalRecursiveSave();
}


public RC_003b51eef272cce91f55924f504b1b11 Duplicate() {
RC_003b51eef272cce91f55924f504b1b11 t;
t.ssENOrderRequestFileComment = (EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord)this.ssENOrderRequestFileComment.Duplicate();
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
if (head == "orderrequestfilecomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileComment")) variable.Value = ssENOrderRequestFileComment; else variable.Optimized = true;
variable.SetFieldName("orderrequestfilecomment");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderRequestFileComment.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderRequestFileComment.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderRequestFileComment) {
return ssENOrderRequestFileComment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFileComment.Key.AsGuid) {
return ssENOrderRequestFileComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderRequestFileComment.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileComment));
}
} // RC_003b51eef272cce91f55924f504b1b11
/// <summary>
/// RecordList type <code>OrderRequestFileCommentRecordList</code> that represents a record list of
///  <code>OrderRequestFileComment</code>
/// </summary>
public partial class RL_fdc18c89a95b980ffc7dc5524f9f65d7 : GenericRecordList<RC_003b51eef272cce91f55924f504b1b11>, IEnumerable, IEnumerator {

protected override RC_003b51eef272cce91f55924f504b1b11 GetElementDefaultValue() {
return new RC_003b51eef272cce91f55924f504b1b11();
}

public T[] ToArray<T>(Func<RC_003b51eef272cce91f55924f504b1b11, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fdc18c89a95b980ffc7dc5524f9f65d7 recordList, Func<RC_003b51eef272cce91f55924f504b1b11, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fdc18c89a95b980ffc7dc5524f9f65d7(RC_003b51eef272cce91f55924f504b1b11[] array) {
  RL_fdc18c89a95b980ffc7dc5524f9f65d7 result = new RL_fdc18c89a95b980ffc7dc5524f9f65d7();
result.InnerFromArray(array);
    return result;
}

public static RL_fdc18c89a95b980ffc7dc5524f9f65d7 ToList<T>(T[] array, Func <T, RC_003b51eef272cce91f55924f504b1b11> converter) {
  RL_fdc18c89a95b980ffc7dc5524f9f65d7 result = new RL_fdc18c89a95b980ffc7dc5524f9f65d7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fdc18c89a95b980ffc7dc5524f9f65d7 FromRestList<T>(RestList<T> restList, Func <T, RC_003b51eef272cce91f55924f504b1b11> converter) {
  RL_fdc18c89a95b980ffc7dc5524f9f65d7 result = new RL_fdc18c89a95b980ffc7dc5524f9f65d7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fdc18c89a95b980ffc7dc5524f9f65d7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_003b51eef272cce91f55924f504b1b11> NewList() {
return new RL_fdc18c89a95b980ffc7dc5524f9f65d7();
}


} // RL_fdc18c89a95b980ffc7dc5524f9f65d7
}

