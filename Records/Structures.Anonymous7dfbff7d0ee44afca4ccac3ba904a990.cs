namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ff_7feQO_EqkzKw7qQSpkA)
///  <code>RC_506e7681e4494051bd2c8f2d45737647</code> that represent
/// s <code>ZMXFFIMF_CONTA_FACTURASReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXFFIMF_CONTA_FACTURASReqRecord
public partial struct RC_506e7681e4494051bd2c8f2d45737647 : ITypedRecord<RC_506e7681e4494051bd2c8f2d45737647> {
internal static readonly GlobalObjectKey IdZMXFFIMF_CONTA_FACTURASReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gXZuUEnkUUC9LI8tRXN2Rw");

public ST_012aef00497ef6b298e25799608b1289Structure ssSTZMXFFIMF_CONTA_FACTURASReq;


public static implicit operator ST_012aef00497ef6b298e25799608b1289Structure( RC_506e7681e4494051bd2c8f2d45737647 r) {
return r.ssSTZMXFFIMF_CONTA_FACTURASReq;
}

public static implicit operator RC_506e7681e4494051bd2c8f2d45737647 (ST_012aef00497ef6b298e25799608b1289Structure r) {
RC_506e7681e4494051bd2c8f2d45737647 res = new RC_506e7681e4494051bd2c8f2d45737647 ();
res.ssSTZMXFFIMF_CONTA_FACTURASReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_506e7681e4494051bd2c8f2d45737647() {
OptimizedAttributes = null;
ssSTZMXFFIMF_CONTA_FACTURASReq = new ST_012aef00497ef6b298e25799608b1289Structure();
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
    ssSTZMXFFIMF_CONTA_FACTURASReq.OptimizedAttributes = value[0];
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
ssSTZMXFFIMF_CONTA_FACTURASReq.Read( r, ref index);
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
public void ReadIM(RC_506e7681e4494051bd2c8f2d45737647 r) {
this = r;
}


public static bool operator == (RC_506e7681e4494051bd2c8f2d45737647 a, RC_506e7681e4494051bd2c8f2d45737647 b) {
if (a.ssSTZMXFFIMF_CONTA_FACTURASReq != b.ssSTZMXFFIMF_CONTA_FACTURASReq) return false;
return true;
}

public static bool operator != (RC_506e7681e4494051bd2c8f2d45737647 a, RC_506e7681e4494051bd2c8f2d45737647 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_506e7681e4494051bd2c8f2d45737647)) return false;
return (this == (RC_506e7681e4494051bd2c8f2d45737647)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXFFIMF_CONTA_FACTURASReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXFFIMF_CONTA_FACTURASReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXFFIMF_CONTA_FACTURASReq.InternalRecursiveSave();
}


public RC_506e7681e4494051bd2c8f2d45737647 Duplicate() {
RC_506e7681e4494051bd2c8f2d45737647 t;
t.ssSTZMXFFIMF_CONTA_FACTURASReq = (ST_012aef00497ef6b298e25799608b1289Structure)this.ssSTZMXFFIMF_CONTA_FACTURASReq.Duplicate();
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
if (head == "zmxffimf_conta_facturasreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXFFIMF_CONTA_FACTURASReq")) variable.Value = ssSTZMXFFIMF_CONTA_FACTURASReq; else variable.Optimized = true;
variable.SetFieldName("zmxffimf_conta_facturasreq");
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
if (key == IdZMXFFIMF_CONTA_FACTURASReq) {
return ssSTZMXFFIMF_CONTA_FACTURASReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXFFIMF_CONTA_FACTURASReq.Key.AsGuid) {
return ssSTZMXFFIMF_CONTA_FACTURASReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXFFIMF_CONTA_FACTURASReq.FillFromOther((IRecord) other.AttributeGet(IdZMXFFIMF_CONTA_FACTURASReq));
}
} // RC_506e7681e4494051bd2c8f2d45737647
/// <summary>
/// RecordList type <code>ZMXFFIMF_CONTA_FACTURASReqRecordList</code> that represents a record list of
///  <code>ZMXFFIMF_CONTA_FACTURASReq</code>
/// </summary>
public partial class RL_0aee438b0e18015867a256efae7aa88b : GenericRecordList<RC_506e7681e4494051bd2c8f2d45737647>, IEnumerable, IEnumerator {

protected override RC_506e7681e4494051bd2c8f2d45737647 GetElementDefaultValue() {
return new RC_506e7681e4494051bd2c8f2d45737647();
}

public T[] ToArray<T>(Func<RC_506e7681e4494051bd2c8f2d45737647, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0aee438b0e18015867a256efae7aa88b recordList, Func<RC_506e7681e4494051bd2c8f2d45737647, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0aee438b0e18015867a256efae7aa88b(RC_506e7681e4494051bd2c8f2d45737647[] array) {
  RL_0aee438b0e18015867a256efae7aa88b result = new RL_0aee438b0e18015867a256efae7aa88b();
result.InnerFromArray(array);
    return result;
}

public static RL_0aee438b0e18015867a256efae7aa88b ToList<T>(T[] array, Func <T, RC_506e7681e4494051bd2c8f2d45737647> converter) {
  RL_0aee438b0e18015867a256efae7aa88b result = new RL_0aee438b0e18015867a256efae7aa88b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0aee438b0e18015867a256efae7aa88b FromRestList<T>(RestList<T> restList, Func <T, RC_506e7681e4494051bd2c8f2d45737647> converter) {
  RL_0aee438b0e18015867a256efae7aa88b result = new RL_0aee438b0e18015867a256efae7aa88b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0aee438b0e18015867a256efae7aa88b() : base() {
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
protected override OSList<RC_506e7681e4494051bd2c8f2d45737647> NewList() {
return new RL_0aee438b0e18015867a256efae7aa88b();
}


} // RL_0aee438b0e18015867a256efae7aa88b
}

