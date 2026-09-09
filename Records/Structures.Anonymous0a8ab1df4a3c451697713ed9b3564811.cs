namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (37GKCjxKFkWXcT7Zs1ZIEQ)
///  <code>RC_2c1b3c205a8ef6cb9caa168a859ca828</code> that represents <code>CommentTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CommentTypeRecord
public partial struct RC_2c1b3c205a8ef6cb9caa168a859ca828 : ITypedRecord<RC_2c1b3c205a8ef6cb9caa168a859ca828> {
internal static readonly GlobalObjectKey IdCommentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IDwbLI5ay_acqhaKhZyoKA");

public EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord ssENCommentType;


public static implicit operator EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord( RC_2c1b3c205a8ef6cb9caa168a859ca828 r) {
return r.ssENCommentType;
}

public static implicit operator RC_2c1b3c205a8ef6cb9caa168a859ca828 (EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord r) {
RC_2c1b3c205a8ef6cb9caa168a859ca828 res = new RC_2c1b3c205a8ef6cb9caa168a859ca828 ();
res.ssENCommentType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCommentType.ChangedAttributes = value;
}
get {
    return ssENCommentType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2c1b3c205a8ef6cb9caa168a859ca828() {
OptimizedAttributes = null;
ssENCommentType = new EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCommentType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCommentType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCommentType.OptimizedAttributes;
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
public void ReadIM(RC_2c1b3c205a8ef6cb9caa168a859ca828 r) {
this = r;
}


public static bool operator == (RC_2c1b3c205a8ef6cb9caa168a859ca828 a, RC_2c1b3c205a8ef6cb9caa168a859ca828 b) {
if (a.ssENCommentType != b.ssENCommentType) return false;
return true;
}

public static bool operator != (RC_2c1b3c205a8ef6cb9caa168a859ca828 a, RC_2c1b3c205a8ef6cb9caa168a859ca828 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2c1b3c205a8ef6cb9caa168a859ca828)) return false;
return (this == (RC_2c1b3c205a8ef6cb9caa168a859ca828)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCommentType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCommentType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCommentType.InternalRecursiveSave();
}


public RC_2c1b3c205a8ef6cb9caa168a859ca828 Duplicate() {
RC_2c1b3c205a8ef6cb9caa168a859ca828 t;
t.ssENCommentType = (EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord)this.ssENCommentType.Duplicate();
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
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCommentType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCommentType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCommentType) {
return ssENCommentType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCommentType.Key.AsGuid) {
return ssENCommentType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCommentType.FillFromOther((IRecord) other.AttributeGet(IdCommentType));
}
} // RC_2c1b3c205a8ef6cb9caa168a859ca828
/// <summary>
/// RecordList type <code>CommentTypeRecordList</code> that represents a record list of
///  <code>CommentType</code>
/// </summary>
public partial class RL_79290c98a21e0b59572e43c54c4bef1e : GenericRecordList<RC_2c1b3c205a8ef6cb9caa168a859ca828>, IEnumerable, IEnumerator {

protected override RC_2c1b3c205a8ef6cb9caa168a859ca828 GetElementDefaultValue() {
return new RC_2c1b3c205a8ef6cb9caa168a859ca828();
}

public T[] ToArray<T>(Func<RC_2c1b3c205a8ef6cb9caa168a859ca828, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_79290c98a21e0b59572e43c54c4bef1e recordList, Func<RC_2c1b3c205a8ef6cb9caa168a859ca828, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_79290c98a21e0b59572e43c54c4bef1e(RC_2c1b3c205a8ef6cb9caa168a859ca828[] array) {
  RL_79290c98a21e0b59572e43c54c4bef1e result = new RL_79290c98a21e0b59572e43c54c4bef1e();
result.InnerFromArray(array);
    return result;
}

public static RL_79290c98a21e0b59572e43c54c4bef1e ToList<T>(T[] array, Func <T, RC_2c1b3c205a8ef6cb9caa168a859ca828> converter) {
  RL_79290c98a21e0b59572e43c54c4bef1e result = new RL_79290c98a21e0b59572e43c54c4bef1e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_79290c98a21e0b59572e43c54c4bef1e FromRestList<T>(RestList<T> restList, Func <T, RC_2c1b3c205a8ef6cb9caa168a859ca828> converter) {
  RL_79290c98a21e0b59572e43c54c4bef1e result = new RL_79290c98a21e0b59572e43c54c4bef1e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_79290c98a21e0b59572e43c54c4bef1e() : base() {
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
protected override OSList<RC_2c1b3c205a8ef6cb9caa168a859ca828> NewList() {
return new RL_79290c98a21e0b59572e43c54c4bef1e();
}


} // RL_79290c98a21e0b59572e43c54c4bef1e
}

