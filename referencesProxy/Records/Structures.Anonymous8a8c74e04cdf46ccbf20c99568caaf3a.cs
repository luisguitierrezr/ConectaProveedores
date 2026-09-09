namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (4HSMit9MzEa_IMmVaMqvOg)
///  <code>RC_aaf77cde47982cd889d3f7caafb8e2be</code> that represent
/// s <code>ZMXFFIMF_OBT_TIP_CAMRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXFFIMF_OBT_TIP_CAMRespRecord
public partial struct RC_aaf77cde47982cd889d3f7caafb8e2be : ITypedRecord<RC_aaf77cde47982cd889d3f7caafb8e2be> {
internal static readonly GlobalObjectKey IdZMXFFIMF_OBT_TIP_CAMResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3nz3qphH2CyJ0_fKr7jivg");

public ST_72813e0dac5e52c872182de62adb7f2bStructure ssSTZMXFFIMF_OBT_TIP_CAMResp;


public static implicit operator ST_72813e0dac5e52c872182de62adb7f2bStructure( RC_aaf77cde47982cd889d3f7caafb8e2be r) {
return r.ssSTZMXFFIMF_OBT_TIP_CAMResp;
}

public static implicit operator RC_aaf77cde47982cd889d3f7caafb8e2be (ST_72813e0dac5e52c872182de62adb7f2bStructure r) {
RC_aaf77cde47982cd889d3f7caafb8e2be res = new RC_aaf77cde47982cd889d3f7caafb8e2be ();
res.ssSTZMXFFIMF_OBT_TIP_CAMResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_aaf77cde47982cd889d3f7caafb8e2be() {
OptimizedAttributes = null;
ssSTZMXFFIMF_OBT_TIP_CAMResp = new ST_72813e0dac5e52c872182de62adb7f2bStructure();
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
    ssSTZMXFFIMF_OBT_TIP_CAMResp.OptimizedAttributes = value[0];
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
ssSTZMXFFIMF_OBT_TIP_CAMResp.Read( r, ref index);
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
public void ReadIM(RC_aaf77cde47982cd889d3f7caafb8e2be r) {
this = r;
}


public static bool operator == (RC_aaf77cde47982cd889d3f7caafb8e2be a, RC_aaf77cde47982cd889d3f7caafb8e2be b) {
if (a.ssSTZMXFFIMF_OBT_TIP_CAMResp != b.ssSTZMXFFIMF_OBT_TIP_CAMResp) return false;
return true;
}

public static bool operator != (RC_aaf77cde47982cd889d3f7caafb8e2be a, RC_aaf77cde47982cd889d3f7caafb8e2be b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_aaf77cde47982cd889d3f7caafb8e2be)) return false;
return (this == (RC_aaf77cde47982cd889d3f7caafb8e2be)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXFFIMF_OBT_TIP_CAMResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXFFIMF_OBT_TIP_CAMResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXFFIMF_OBT_TIP_CAMResp.InternalRecursiveSave();
}


public RC_aaf77cde47982cd889d3f7caafb8e2be Duplicate() {
RC_aaf77cde47982cd889d3f7caafb8e2be t;
t.ssSTZMXFFIMF_OBT_TIP_CAMResp = (ST_72813e0dac5e52c872182de62adb7f2bStructure)this.ssSTZMXFFIMF_OBT_TIP_CAMResp.Duplicate();
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
if (head == "zmxffimf_obt_tip_camresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXFFIMF_OBT_TIP_CAMResp")) variable.Value = ssSTZMXFFIMF_OBT_TIP_CAMResp; else variable.Optimized = true;
variable.SetFieldName("zmxffimf_obt_tip_camresp");
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
if (key == IdZMXFFIMF_OBT_TIP_CAMResp) {
return ssSTZMXFFIMF_OBT_TIP_CAMResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXFFIMF_OBT_TIP_CAMResp.Key.AsGuid) {
return ssSTZMXFFIMF_OBT_TIP_CAMResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXFFIMF_OBT_TIP_CAMResp.FillFromOther((IRecord) other.AttributeGet(IdZMXFFIMF_OBT_TIP_CAMResp));
}
} // RC_aaf77cde47982cd889d3f7caafb8e2be
/// <summary>
/// RecordList type <code>ZMXFFIMF_OBT_TIP_CAMRespRecordList</code> that represents a record list of
///  <code>ZMXFFIMF_OBT_TIP_CAMResp</code>
/// </summary>
public partial class RL_598a78fc8e465329d37c7b62adee6ac8 : GenericRecordList<RC_aaf77cde47982cd889d3f7caafb8e2be>, IEnumerable, IEnumerator {

protected override RC_aaf77cde47982cd889d3f7caafb8e2be GetElementDefaultValue() {
return new RC_aaf77cde47982cd889d3f7caafb8e2be();
}

public T[] ToArray<T>(Func<RC_aaf77cde47982cd889d3f7caafb8e2be, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_598a78fc8e465329d37c7b62adee6ac8 recordList, Func<RC_aaf77cde47982cd889d3f7caafb8e2be, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_598a78fc8e465329d37c7b62adee6ac8(RC_aaf77cde47982cd889d3f7caafb8e2be[] array) {
  RL_598a78fc8e465329d37c7b62adee6ac8 result = new RL_598a78fc8e465329d37c7b62adee6ac8();
result.InnerFromArray(array);
    return result;
}

public static RL_598a78fc8e465329d37c7b62adee6ac8 ToList<T>(T[] array, Func <T, RC_aaf77cde47982cd889d3f7caafb8e2be> converter) {
  RL_598a78fc8e465329d37c7b62adee6ac8 result = new RL_598a78fc8e465329d37c7b62adee6ac8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_598a78fc8e465329d37c7b62adee6ac8 FromRestList<T>(RestList<T> restList, Func <T, RC_aaf77cde47982cd889d3f7caafb8e2be> converter) {
  RL_598a78fc8e465329d37c7b62adee6ac8 result = new RL_598a78fc8e465329d37c7b62adee6ac8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_598a78fc8e465329d37c7b62adee6ac8() : base() {
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
protected override OSList<RC_aaf77cde47982cd889d3f7caafb8e2be> NewList() {
return new RL_598a78fc8e465329d37c7b62adee6ac8();
}


} // RL_598a78fc8e465329d37c7b62adee6ac8
}

