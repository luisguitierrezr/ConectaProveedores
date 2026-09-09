namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (gLlcOQRQbUGCGnEOJzKrHw)
///  <code>RC_23e4ac7b03ba2050af5811737c8cc89f</code> that represents <code>VideoCaptionsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: VideoCaptionsRecord
public partial struct RC_23e4ac7b03ba2050af5811737c8cc89f : ITypedRecord<RC_23e4ac7b03ba2050af5811737c8cc89f> {
internal static readonly GlobalObjectKey IdVideoCaptions = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*e6zkI7oDUCCvWBFzfIzInw");

public ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure ssSTVideoCaptions;


public static implicit operator ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure( RC_23e4ac7b03ba2050af5811737c8cc89f r) {
return r.ssSTVideoCaptions;
}

public static implicit operator RC_23e4ac7b03ba2050af5811737c8cc89f (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure r) {
RC_23e4ac7b03ba2050af5811737c8cc89f res = new RC_23e4ac7b03ba2050af5811737c8cc89f ();
res.ssSTVideoCaptions = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_23e4ac7b03ba2050af5811737c8cc89f() {
OptimizedAttributes = null;
ssSTVideoCaptions = new ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTVideoCaptions.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTVideoCaptions.Read( r, ref index);
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
public void ReadIM(RC_23e4ac7b03ba2050af5811737c8cc89f r) {
this = r;
}


public static bool operator == (RC_23e4ac7b03ba2050af5811737c8cc89f a, RC_23e4ac7b03ba2050af5811737c8cc89f b) {
if (a.ssSTVideoCaptions != b.ssSTVideoCaptions) return false;
return true;
}

public static bool operator != (RC_23e4ac7b03ba2050af5811737c8cc89f a, RC_23e4ac7b03ba2050af5811737c8cc89f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_23e4ac7b03ba2050af5811737c8cc89f)) return false;
return (this == (RC_23e4ac7b03ba2050af5811737c8cc89f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTVideoCaptions.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTVideoCaptions.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTVideoCaptions.InternalRecursiveSave();
}


public RC_23e4ac7b03ba2050af5811737c8cc89f Duplicate() {
RC_23e4ac7b03ba2050af5811737c8cc89f t;
t.ssSTVideoCaptions = (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure)this.ssSTVideoCaptions.Duplicate();
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
if (head == "videocaptions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VideoCaptions")) variable.Value = ssSTVideoCaptions; else variable.Optimized = true;
variable.SetFieldName("videocaptions");
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
if (key == IdVideoCaptions) {
return ssSTVideoCaptions;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdVideoCaptions.Key.AsGuid) {
return ssSTVideoCaptions;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTVideoCaptions.FillFromOther((IRecord) other.AttributeGet(IdVideoCaptions));
}
} // RC_23e4ac7b03ba2050af5811737c8cc89f
/// <summary>
/// RecordList type <code>VideoCaptionsRecordList</code> that represents a record list of
///  <code>VideoCaptions</code>
/// </summary>
public partial class RL_a9a9108148017b3108e7788d5e0b597c : GenericRecordList<RC_23e4ac7b03ba2050af5811737c8cc89f>, IEnumerable, IEnumerator {

protected override RC_23e4ac7b03ba2050af5811737c8cc89f GetElementDefaultValue() {
return new RC_23e4ac7b03ba2050af5811737c8cc89f();
}

public T[] ToArray<T>(Func<RC_23e4ac7b03ba2050af5811737c8cc89f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a9a9108148017b3108e7788d5e0b597c recordList, Func<RC_23e4ac7b03ba2050af5811737c8cc89f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a9a9108148017b3108e7788d5e0b597c(RC_23e4ac7b03ba2050af5811737c8cc89f[] array) {
  RL_a9a9108148017b3108e7788d5e0b597c result = new RL_a9a9108148017b3108e7788d5e0b597c();
result.InnerFromArray(array);
    return result;
}

public static RL_a9a9108148017b3108e7788d5e0b597c ToList<T>(T[] array, Func <T, RC_23e4ac7b03ba2050af5811737c8cc89f> converter) {
  RL_a9a9108148017b3108e7788d5e0b597c result = new RL_a9a9108148017b3108e7788d5e0b597c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a9a9108148017b3108e7788d5e0b597c FromRestList<T>(RestList<T> restList, Func <T, RC_23e4ac7b03ba2050af5811737c8cc89f> converter) {
  RL_a9a9108148017b3108e7788d5e0b597c result = new RL_a9a9108148017b3108e7788d5e0b597c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a9a9108148017b3108e7788d5e0b597c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_23e4ac7b03ba2050af5811737c8cc89f> NewList() {
return new RL_a9a9108148017b3108e7788d5e0b597c();
}


} // RL_a9a9108148017b3108e7788d5e0b597c
}

