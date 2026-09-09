namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (sK5I7FK9f02w4E_3hNg1XA)
///  <code>RC_45b72d53609a7a1da4a98878c5ec7590</code> that represent
/// s <code>CommentTypeOrderRequestFileCommentRecord</code> <p>Description: </p>
/// </summary>
// Name: CommentTypeOrderRequestFileCommentRecord
public partial struct RC_45b72d53609a7a1da4a98878c5ec7590 : ITypedRecord<RC_45b72d53609a7a1da4a98878c5ec7590> {
internal static readonly GlobalObjectKey IdCommentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IDwbLI5ay_acqhaKhZyoKA");
internal static readonly GlobalObjectKey IdOrderRequestFileComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7lE7AHLy6cwfVZJPUEsbEQ");

public EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord ssENCommentType;

public EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord ssENOrderRequestFileComment;


public BitArray OptimizedAttributes;

public RC_45b72d53609a7a1da4a98878c5ec7590() {
OptimizedAttributes = null;
ssENCommentType = new EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord();
ssENOrderRequestFileComment = new EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCommentType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderRequestFileComment.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENCommentType.OptimizedAttributes = value[0];
    ssENOrderRequestFileComment.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENCommentType.OptimizedAttributes;
    all[1] = ssENOrderRequestFileComment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCommentType.Read( r, ref index);
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
public void ReadIM(RC_45b72d53609a7a1da4a98878c5ec7590 r) {
this = r;
}


public static bool operator == (RC_45b72d53609a7a1da4a98878c5ec7590 a, RC_45b72d53609a7a1da4a98878c5ec7590 b) {
if (a.ssENCommentType != b.ssENCommentType) return false;
if (a.ssENOrderRequestFileComment != b.ssENOrderRequestFileComment) return false;
return true;
}

public static bool operator != (RC_45b72d53609a7a1da4a98878c5ec7590 a, RC_45b72d53609a7a1da4a98878c5ec7590 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_45b72d53609a7a1da4a98878c5ec7590)) return false;
return (this == (RC_45b72d53609a7a1da4a98878c5ec7590)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCommentType.GetHashCode()
 ^ ssENOrderRequestFileComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCommentType.RecursiveReset();
ssENOrderRequestFileComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCommentType.InternalRecursiveSave();
ssENOrderRequestFileComment.InternalRecursiveSave();
}


public RC_45b72d53609a7a1da4a98878c5ec7590 Duplicate() {
RC_45b72d53609a7a1da4a98878c5ec7590 t;
t.ssENCommentType = (EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord)this.ssENCommentType.Duplicate();
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
if (head == "commenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommentType")) variable.Value = ssENCommentType; else variable.Optimized = true;
variable.SetFieldName("commenttype");
} else if (head == "orderrequestfilecomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileComment")) variable.Value = ssENOrderRequestFileComment; else variable.Optimized = true;
variable.SetFieldName("orderrequestfilecomment");
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
if (key == IdCommentType) {
return ssENCommentType;
}
if (key == IdOrderRequestFileComment) {
return ssENOrderRequestFileComment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCommentType.Key.AsGuid) {
return ssENCommentType;
}
if (attributeKey == IdOrderRequestFileComment.Key.AsGuid) {
return ssENOrderRequestFileComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCommentType.FillFromOther((IRecord) other.AttributeGet(IdCommentType));
ssENOrderRequestFileComment.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileComment));
}
} // RC_45b72d53609a7a1da4a98878c5ec7590
/// <summary>
/// RecordList type <code>CommentTypeOrderRequestFileCommentRecordList</code> that represents a record
///  list of <code>CommentType, OrderRequestFileComment</code>
/// </summary>
public partial class RL_520d7bdfa592e7631b7e51777aa739f1 : GenericRecordList<RC_45b72d53609a7a1da4a98878c5ec7590>, IEnumerable, IEnumerator {

protected override RC_45b72d53609a7a1da4a98878c5ec7590 GetElementDefaultValue() {
return new RC_45b72d53609a7a1da4a98878c5ec7590();
}

public T[] ToArray<T>(Func<RC_45b72d53609a7a1da4a98878c5ec7590, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_520d7bdfa592e7631b7e51777aa739f1 recordList, Func<RC_45b72d53609a7a1da4a98878c5ec7590, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_520d7bdfa592e7631b7e51777aa739f1(RC_45b72d53609a7a1da4a98878c5ec7590[] array) {
  RL_520d7bdfa592e7631b7e51777aa739f1 result = new RL_520d7bdfa592e7631b7e51777aa739f1();
result.InnerFromArray(array);
    return result;
}

public static RL_520d7bdfa592e7631b7e51777aa739f1 ToList<T>(T[] array, Func <T, RC_45b72d53609a7a1da4a98878c5ec7590> converter) {
  RL_520d7bdfa592e7631b7e51777aa739f1 result = new RL_520d7bdfa592e7631b7e51777aa739f1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_520d7bdfa592e7631b7e51777aa739f1 FromRestList<T>(RestList<T> restList, Func <T, RC_45b72d53609a7a1da4a98878c5ec7590> converter) {
  RL_520d7bdfa592e7631b7e51777aa739f1 result = new RL_520d7bdfa592e7631b7e51777aa739f1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_520d7bdfa592e7631b7e51777aa739f1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_45b72d53609a7a1da4a98878c5ec7590> NewList() {
return new RL_520d7bdfa592e7631b7e51777aa739f1();
}


} // RL_520d7bdfa592e7631b7e51777aa739f1
}

