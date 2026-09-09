namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (PgmmT6EvMUSYtKFrlQ4wqg)
///  <code>RC_cb1635938264c06d8723ef02327570a7</code> that represents <code>PI_HEADER4Record</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER4Record
public partial struct RC_cb1635938264c06d8723ef02327570a7 : ITypedRecord<RC_cb1635938264c06d8723ef02327570a7> {
internal static readonly GlobalObjectKey IdPI_HEADER4 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kzUWy2SCbcCHI+8CMnVwpw");

public ST_b8bada9441ba6abcbadb418a924fe551Structure ssSTPI_HEADER4;


public static implicit operator ST_b8bada9441ba6abcbadb418a924fe551Structure( RC_cb1635938264c06d8723ef02327570a7 r) {
return r.ssSTPI_HEADER4;
}

public static implicit operator RC_cb1635938264c06d8723ef02327570a7 (ST_b8bada9441ba6abcbadb418a924fe551Structure r) {
RC_cb1635938264c06d8723ef02327570a7 res = new RC_cb1635938264c06d8723ef02327570a7 ();
res.ssSTPI_HEADER4 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_cb1635938264c06d8723ef02327570a7() {
OptimizedAttributes = null;
ssSTPI_HEADER4 = new ST_b8bada9441ba6abcbadb418a924fe551Structure();
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
    ssSTPI_HEADER4.OptimizedAttributes = value[0];
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
ssSTPI_HEADER4.Read( r, ref index);
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
public void ReadIM(RC_cb1635938264c06d8723ef02327570a7 r) {
this = r;
}


public static bool operator == (RC_cb1635938264c06d8723ef02327570a7 a, RC_cb1635938264c06d8723ef02327570a7 b) {
if (a.ssSTPI_HEADER4 != b.ssSTPI_HEADER4) return false;
return true;
}

public static bool operator != (RC_cb1635938264c06d8723ef02327570a7 a, RC_cb1635938264c06d8723ef02327570a7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cb1635938264c06d8723ef02327570a7)) return false;
return (this == (RC_cb1635938264c06d8723ef02327570a7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_HEADER4.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_HEADER4.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_HEADER4.InternalRecursiveSave();
}


public RC_cb1635938264c06d8723ef02327570a7 Duplicate() {
RC_cb1635938264c06d8723ef02327570a7 t;
t.ssSTPI_HEADER4 = (ST_b8bada9441ba6abcbadb418a924fe551Structure)this.ssSTPI_HEADER4.Duplicate();
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
if (head == "pi_header4") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER4")) variable.Value = ssSTPI_HEADER4; else variable.Optimized = true;
variable.SetFieldName("pi_header4");
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
if (key == IdPI_HEADER4) {
return ssSTPI_HEADER4;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER4.Key.AsGuid) {
return ssSTPI_HEADER4;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_HEADER4.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER4));
}
} // RC_cb1635938264c06d8723ef02327570a7
/// <summary>
/// RecordList type <code>PI_HEADER4RecordList</code> that represents a record list of
///  <code>PI_HEADER4</code>
/// </summary>
public partial class RL_9ff3f7b75a15a34af6ce2f0c163b12cb : GenericRecordList<RC_cb1635938264c06d8723ef02327570a7>, IEnumerable, IEnumerator {

protected override RC_cb1635938264c06d8723ef02327570a7 GetElementDefaultValue() {
return new RC_cb1635938264c06d8723ef02327570a7();
}

public T[] ToArray<T>(Func<RC_cb1635938264c06d8723ef02327570a7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9ff3f7b75a15a34af6ce2f0c163b12cb recordList, Func<RC_cb1635938264c06d8723ef02327570a7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9ff3f7b75a15a34af6ce2f0c163b12cb(RC_cb1635938264c06d8723ef02327570a7[] array) {
  RL_9ff3f7b75a15a34af6ce2f0c163b12cb result = new RL_9ff3f7b75a15a34af6ce2f0c163b12cb();
result.InnerFromArray(array);
    return result;
}

public static RL_9ff3f7b75a15a34af6ce2f0c163b12cb ToList<T>(T[] array, Func <T, RC_cb1635938264c06d8723ef02327570a7> converter) {
  RL_9ff3f7b75a15a34af6ce2f0c163b12cb result = new RL_9ff3f7b75a15a34af6ce2f0c163b12cb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9ff3f7b75a15a34af6ce2f0c163b12cb FromRestList<T>(RestList<T> restList, Func <T, RC_cb1635938264c06d8723ef02327570a7> converter) {
  RL_9ff3f7b75a15a34af6ce2f0c163b12cb result = new RL_9ff3f7b75a15a34af6ce2f0c163b12cb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9ff3f7b75a15a34af6ce2f0c163b12cb() : base() {
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
protected override OSList<RC_cb1635938264c06d8723ef02327570a7> NewList() {
return new RL_9ff3f7b75a15a34af6ce2f0c163b12cb();
}


} // RL_9ff3f7b75a15a34af6ce2f0c163b12cb
}

