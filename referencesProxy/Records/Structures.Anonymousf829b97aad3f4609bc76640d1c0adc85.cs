namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (erkp+D+tCUa8dmQNHArchQ)
///  <code>RC_4b108b87f78506440b6fe2b6ab61c481</code> that represent
/// s <code>ZMXFFIMF_OBT_TIP_CAMReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXFFIMF_OBT_TIP_CAMReqRecord
public partial struct RC_4b108b87f78506440b6fe2b6ab61c481 : ITypedRecord<RC_4b108b87f78506440b6fe2b6ab61c481> {
internal static readonly GlobalObjectKey IdZMXFFIMF_OBT_TIP_CAMReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*h4sQS4X3RAYLb+K2q2HEgQ");

public ST_694abc44952847f050feca404fbee9c5Structure ssSTZMXFFIMF_OBT_TIP_CAMReq;


public static implicit operator ST_694abc44952847f050feca404fbee9c5Structure( RC_4b108b87f78506440b6fe2b6ab61c481 r) {
return r.ssSTZMXFFIMF_OBT_TIP_CAMReq;
}

public static implicit operator RC_4b108b87f78506440b6fe2b6ab61c481 (ST_694abc44952847f050feca404fbee9c5Structure r) {
RC_4b108b87f78506440b6fe2b6ab61c481 res = new RC_4b108b87f78506440b6fe2b6ab61c481 ();
res.ssSTZMXFFIMF_OBT_TIP_CAMReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4b108b87f78506440b6fe2b6ab61c481() {
OptimizedAttributes = null;
ssSTZMXFFIMF_OBT_TIP_CAMReq = new ST_694abc44952847f050feca404fbee9c5Structure();
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
    ssSTZMXFFIMF_OBT_TIP_CAMReq.OptimizedAttributes = value[0];
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
ssSTZMXFFIMF_OBT_TIP_CAMReq.Read( r, ref index);
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
public void ReadIM(RC_4b108b87f78506440b6fe2b6ab61c481 r) {
this = r;
}


public static bool operator == (RC_4b108b87f78506440b6fe2b6ab61c481 a, RC_4b108b87f78506440b6fe2b6ab61c481 b) {
if (a.ssSTZMXFFIMF_OBT_TIP_CAMReq != b.ssSTZMXFFIMF_OBT_TIP_CAMReq) return false;
return true;
}

public static bool operator != (RC_4b108b87f78506440b6fe2b6ab61c481 a, RC_4b108b87f78506440b6fe2b6ab61c481 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4b108b87f78506440b6fe2b6ab61c481)) return false;
return (this == (RC_4b108b87f78506440b6fe2b6ab61c481)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXFFIMF_OBT_TIP_CAMReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXFFIMF_OBT_TIP_CAMReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXFFIMF_OBT_TIP_CAMReq.InternalRecursiveSave();
}


public RC_4b108b87f78506440b6fe2b6ab61c481 Duplicate() {
RC_4b108b87f78506440b6fe2b6ab61c481 t;
t.ssSTZMXFFIMF_OBT_TIP_CAMReq = (ST_694abc44952847f050feca404fbee9c5Structure)this.ssSTZMXFFIMF_OBT_TIP_CAMReq.Duplicate();
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
if (head == "zmxffimf_obt_tip_camreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXFFIMF_OBT_TIP_CAMReq")) variable.Value = ssSTZMXFFIMF_OBT_TIP_CAMReq; else variable.Optimized = true;
variable.SetFieldName("zmxffimf_obt_tip_camreq");
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
if (key == IdZMXFFIMF_OBT_TIP_CAMReq) {
return ssSTZMXFFIMF_OBT_TIP_CAMReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXFFIMF_OBT_TIP_CAMReq.Key.AsGuid) {
return ssSTZMXFFIMF_OBT_TIP_CAMReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXFFIMF_OBT_TIP_CAMReq.FillFromOther((IRecord) other.AttributeGet(IdZMXFFIMF_OBT_TIP_CAMReq));
}
} // RC_4b108b87f78506440b6fe2b6ab61c481
/// <summary>
/// RecordList type <code>ZMXFFIMF_OBT_TIP_CAMReqRecordList</code> that represents a record list of
///  <code>ZMXFFIMF_OBT_TIP_CAMReq</code>
/// </summary>
public partial class RL_9b6c7d15b8ca58da43168c6300aa96b4 : GenericRecordList<RC_4b108b87f78506440b6fe2b6ab61c481>, IEnumerable, IEnumerator {

protected override RC_4b108b87f78506440b6fe2b6ab61c481 GetElementDefaultValue() {
return new RC_4b108b87f78506440b6fe2b6ab61c481();
}

public T[] ToArray<T>(Func<RC_4b108b87f78506440b6fe2b6ab61c481, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9b6c7d15b8ca58da43168c6300aa96b4 recordList, Func<RC_4b108b87f78506440b6fe2b6ab61c481, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9b6c7d15b8ca58da43168c6300aa96b4(RC_4b108b87f78506440b6fe2b6ab61c481[] array) {
  RL_9b6c7d15b8ca58da43168c6300aa96b4 result = new RL_9b6c7d15b8ca58da43168c6300aa96b4();
result.InnerFromArray(array);
    return result;
}

public static RL_9b6c7d15b8ca58da43168c6300aa96b4 ToList<T>(T[] array, Func <T, RC_4b108b87f78506440b6fe2b6ab61c481> converter) {
  RL_9b6c7d15b8ca58da43168c6300aa96b4 result = new RL_9b6c7d15b8ca58da43168c6300aa96b4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9b6c7d15b8ca58da43168c6300aa96b4 FromRestList<T>(RestList<T> restList, Func <T, RC_4b108b87f78506440b6fe2b6ab61c481> converter) {
  RL_9b6c7d15b8ca58da43168c6300aa96b4 result = new RL_9b6c7d15b8ca58da43168c6300aa96b4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9b6c7d15b8ca58da43168c6300aa96b4() : base() {
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
protected override OSList<RC_4b108b87f78506440b6fe2b6ab61c481> NewList() {
return new RL_9b6c7d15b8ca58da43168c6300aa96b4();
}


} // RL_9b6c7d15b8ca58da43168c6300aa96b4
}

