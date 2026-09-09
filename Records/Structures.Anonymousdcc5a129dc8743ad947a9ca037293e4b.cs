namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KaHF3IfcrUOUepygNyk+Sw)
///  <code>RC_cd61721ee82121e78e4055ba4deb1fa6</code> that represents <code>OrderCommentRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderCommentRecord
public partial struct RC_cd61721ee82121e78e4055ba4deb1fa6 : ITypedRecord<RC_cd61721ee82121e78e4055ba4deb1fa6> {
internal static readonly GlobalObjectKey IdOrderComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HnJhzSHo5yGOQFW6Tesfpg");

public EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord ssENOrderComment;


public static implicit operator EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord( RC_cd61721ee82121e78e4055ba4deb1fa6 r) {
return r.ssENOrderComment;
}

public static implicit operator RC_cd61721ee82121e78e4055ba4deb1fa6 (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord r) {
RC_cd61721ee82121e78e4055ba4deb1fa6 res = new RC_cd61721ee82121e78e4055ba4deb1fa6 ();
res.ssENOrderComment = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderComment.ChangedAttributes = value;
}
get {
    return ssENOrderComment.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_cd61721ee82121e78e4055ba4deb1fa6() {
OptimizedAttributes = null;
ssENOrderComment = new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderComment.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderComment.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderComment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderComment.Read( r, ref index);
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
public void ReadIM(RC_cd61721ee82121e78e4055ba4deb1fa6 r) {
this = r;
}


public static bool operator == (RC_cd61721ee82121e78e4055ba4deb1fa6 a, RC_cd61721ee82121e78e4055ba4deb1fa6 b) {
if (a.ssENOrderComment != b.ssENOrderComment) return false;
return true;
}

public static bool operator != (RC_cd61721ee82121e78e4055ba4deb1fa6 a, RC_cd61721ee82121e78e4055ba4deb1fa6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cd61721ee82121e78e4055ba4deb1fa6)) return false;
return (this == (RC_cd61721ee82121e78e4055ba4deb1fa6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderComment.InternalRecursiveSave();
}


public RC_cd61721ee82121e78e4055ba4deb1fa6 Duplicate() {
RC_cd61721ee82121e78e4055ba4deb1fa6 t;
t.ssENOrderComment = (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord)this.ssENOrderComment.Duplicate();
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
if (head == "ordercomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderComment")) variable.Value = ssENOrderComment; else variable.Optimized = true;
variable.SetFieldName("ordercomment");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderComment.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderComment.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderComment) {
return ssENOrderComment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderComment.Key.AsGuid) {
return ssENOrderComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderComment.FillFromOther((IRecord) other.AttributeGet(IdOrderComment));
}
} // RC_cd61721ee82121e78e4055ba4deb1fa6
/// <summary>
/// RecordList type <code>OrderCommentRecordList</code> that represents a record list of
///  <code>OrderComment</code>
/// </summary>
public partial class RL_17d8289ea48572225dc9530a5725652a : GenericRecordList<RC_cd61721ee82121e78e4055ba4deb1fa6>, IEnumerable, IEnumerator {

protected override RC_cd61721ee82121e78e4055ba4deb1fa6 GetElementDefaultValue() {
return new RC_cd61721ee82121e78e4055ba4deb1fa6();
}

public T[] ToArray<T>(Func<RC_cd61721ee82121e78e4055ba4deb1fa6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_17d8289ea48572225dc9530a5725652a recordList, Func<RC_cd61721ee82121e78e4055ba4deb1fa6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_17d8289ea48572225dc9530a5725652a(RC_cd61721ee82121e78e4055ba4deb1fa6[] array) {
  RL_17d8289ea48572225dc9530a5725652a result = new RL_17d8289ea48572225dc9530a5725652a();
result.InnerFromArray(array);
    return result;
}

public static RL_17d8289ea48572225dc9530a5725652a ToList<T>(T[] array, Func <T, RC_cd61721ee82121e78e4055ba4deb1fa6> converter) {
  RL_17d8289ea48572225dc9530a5725652a result = new RL_17d8289ea48572225dc9530a5725652a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_17d8289ea48572225dc9530a5725652a FromRestList<T>(RestList<T> restList, Func <T, RC_cd61721ee82121e78e4055ba4deb1fa6> converter) {
  RL_17d8289ea48572225dc9530a5725652a result = new RL_17d8289ea48572225dc9530a5725652a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_17d8289ea48572225dc9530a5725652a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cd61721ee82121e78e4055ba4deb1fa6> NewList() {
return new RL_17d8289ea48572225dc9530a5725652a();
}


} // RL_17d8289ea48572225dc9530a5725652a
}

