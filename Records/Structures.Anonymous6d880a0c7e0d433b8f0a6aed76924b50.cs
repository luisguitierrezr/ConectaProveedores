namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (DAqIbQ1+O0OPCmrtdpJLUA)
///  <code>RC_235876c2392dec3fee0f6332b46ff11b</code> that represents <code>PI_ITEM_SM3Record</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_SM3Record
public partial struct RC_235876c2392dec3fee0f6332b46ff11b : ITypedRecord<RC_235876c2392dec3fee0f6332b46ff11b> {
internal static readonly GlobalObjectKey IdPI_ITEM_SM3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wnZYIy05P+zuD2MytG_xGw");

public ST_21ada127931bc47aabf2d9a5964b17feStructure ssSTPI_ITEM_SM3;


public static implicit operator ST_21ada127931bc47aabf2d9a5964b17feStructure( RC_235876c2392dec3fee0f6332b46ff11b r) {
return r.ssSTPI_ITEM_SM3;
}

public static implicit operator RC_235876c2392dec3fee0f6332b46ff11b (ST_21ada127931bc47aabf2d9a5964b17feStructure r) {
RC_235876c2392dec3fee0f6332b46ff11b res = new RC_235876c2392dec3fee0f6332b46ff11b ();
res.ssSTPI_ITEM_SM3 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_235876c2392dec3fee0f6332b46ff11b() {
OptimizedAttributes = null;
ssSTPI_ITEM_SM3 = new ST_21ada127931bc47aabf2d9a5964b17feStructure();
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
    ssSTPI_ITEM_SM3.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_SM3.Read( r, ref index);
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
public void ReadIM(RC_235876c2392dec3fee0f6332b46ff11b r) {
this = r;
}


public static bool operator == (RC_235876c2392dec3fee0f6332b46ff11b a, RC_235876c2392dec3fee0f6332b46ff11b b) {
if (a.ssSTPI_ITEM_SM3 != b.ssSTPI_ITEM_SM3) return false;
return true;
}

public static bool operator != (RC_235876c2392dec3fee0f6332b46ff11b a, RC_235876c2392dec3fee0f6332b46ff11b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_235876c2392dec3fee0f6332b46ff11b)) return false;
return (this == (RC_235876c2392dec3fee0f6332b46ff11b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_SM3.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_SM3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_SM3.InternalRecursiveSave();
}


public RC_235876c2392dec3fee0f6332b46ff11b Duplicate() {
RC_235876c2392dec3fee0f6332b46ff11b t;
t.ssSTPI_ITEM_SM3 = (ST_21ada127931bc47aabf2d9a5964b17feStructure)this.ssSTPI_ITEM_SM3.Duplicate();
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
if (head == "pi_item_sm3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_SM3")) variable.Value = ssSTPI_ITEM_SM3; else variable.Optimized = true;
variable.SetFieldName("pi_item_sm3");
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
if (key == IdPI_ITEM_SM3) {
return ssSTPI_ITEM_SM3;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_SM3.Key.AsGuid) {
return ssSTPI_ITEM_SM3;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_SM3.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_SM3));
}
} // RC_235876c2392dec3fee0f6332b46ff11b
/// <summary>
/// RecordList type <code>PI_ITEM_SM3RecordList</code> that represents a record list of
///  <code>PI_ITEM_SM3</code>
/// </summary>
public partial class RL_31d1dfca06be810a75631811f197ca4a : GenericRecordList<RC_235876c2392dec3fee0f6332b46ff11b>, IEnumerable, IEnumerator {

protected override RC_235876c2392dec3fee0f6332b46ff11b GetElementDefaultValue() {
return new RC_235876c2392dec3fee0f6332b46ff11b();
}

public T[] ToArray<T>(Func<RC_235876c2392dec3fee0f6332b46ff11b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_31d1dfca06be810a75631811f197ca4a recordList, Func<RC_235876c2392dec3fee0f6332b46ff11b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_31d1dfca06be810a75631811f197ca4a(RC_235876c2392dec3fee0f6332b46ff11b[] array) {
  RL_31d1dfca06be810a75631811f197ca4a result = new RL_31d1dfca06be810a75631811f197ca4a();
result.InnerFromArray(array);
    return result;
}

public static RL_31d1dfca06be810a75631811f197ca4a ToList<T>(T[] array, Func <T, RC_235876c2392dec3fee0f6332b46ff11b> converter) {
  RL_31d1dfca06be810a75631811f197ca4a result = new RL_31d1dfca06be810a75631811f197ca4a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_31d1dfca06be810a75631811f197ca4a FromRestList<T>(RestList<T> restList, Func <T, RC_235876c2392dec3fee0f6332b46ff11b> converter) {
  RL_31d1dfca06be810a75631811f197ca4a result = new RL_31d1dfca06be810a75631811f197ca4a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_31d1dfca06be810a75631811f197ca4a() : base() {
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
protected override OSList<RC_235876c2392dec3fee0f6332b46ff11b> NewList() {
return new RL_31d1dfca06be810a75631811f197ca4a();
}


} // RL_31d1dfca06be810a75631811f197ca4a
}

