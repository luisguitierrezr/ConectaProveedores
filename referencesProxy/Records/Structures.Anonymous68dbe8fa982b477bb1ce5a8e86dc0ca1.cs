namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (+ujbaCuYe0exzlqOhtwMoQ)
///  <code>RC_6499421cde34cd32d316edf8d06cbcc2</code> that represent
/// s <code>ZMXMIMMF_GENERA_PEDIDO_PDFReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_GENERA_PEDIDO_PDFReqRecord
public partial struct RC_6499421cde34cd32d316edf8d06cbcc2 : ITypedRecord<RC_6499421cde34cd32d316edf8d06cbcc2> {
internal static readonly GlobalObjectKey IdZMXMIMMF_GENERA_PEDIDO_PDFReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HEKZZDTeMs3TFu340Gy8wg");

public ST_7ddccdeb65a44283541a52358876da04Structure ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq;


public static implicit operator ST_7ddccdeb65a44283541a52358876da04Structure( RC_6499421cde34cd32d316edf8d06cbcc2 r) {
return r.ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq;
}

public static implicit operator RC_6499421cde34cd32d316edf8d06cbcc2 (ST_7ddccdeb65a44283541a52358876da04Structure r) {
RC_6499421cde34cd32d316edf8d06cbcc2 res = new RC_6499421cde34cd32d316edf8d06cbcc2 ();
res.ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6499421cde34cd32d316edf8d06cbcc2() {
OptimizedAttributes = null;
ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq = new ST_7ddccdeb65a44283541a52358876da04Structure();
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
    ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq.Read( r, ref index);
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
public void ReadIM(RC_6499421cde34cd32d316edf8d06cbcc2 r) {
this = r;
}


public static bool operator == (RC_6499421cde34cd32d316edf8d06cbcc2 a, RC_6499421cde34cd32d316edf8d06cbcc2 b) {
if (a.ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq != b.ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq) return false;
return true;
}

public static bool operator != (RC_6499421cde34cd32d316edf8d06cbcc2 a, RC_6499421cde34cd32d316edf8d06cbcc2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6499421cde34cd32d316edf8d06cbcc2)) return false;
return (this == (RC_6499421cde34cd32d316edf8d06cbcc2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq.InternalRecursiveSave();
}


public RC_6499421cde34cd32d316edf8d06cbcc2 Duplicate() {
RC_6499421cde34cd32d316edf8d06cbcc2 t;
t.ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq = (ST_7ddccdeb65a44283541a52358876da04Structure)this.ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq.Duplicate();
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
if (head == "zmxmimmf_genera_pedido_pdfreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_GENERA_PEDIDO_PDFReq")) variable.Value = ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_genera_pedido_pdfreq");
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
if (key == IdZMXMIMMF_GENERA_PEDIDO_PDFReq) {
return ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_GENERA_PEDIDO_PDFReq.Key.AsGuid) {
return ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_GENERA_PEDIDO_PDFReq));
}
} // RC_6499421cde34cd32d316edf8d06cbcc2
/// <summary>
/// RecordList type <code>ZMXMIMMF_GENERA_PEDIDO_PDFReqRecordList</code> that represents a record list
///  of <code>ZMXMIMMF_GENERA_PEDIDO_PDFReq</code>
/// </summary>
public partial class RL_78b3e460b8ee2b86cce012a668c82ef2 : GenericRecordList<RC_6499421cde34cd32d316edf8d06cbcc2>, IEnumerable, IEnumerator {

protected override RC_6499421cde34cd32d316edf8d06cbcc2 GetElementDefaultValue() {
return new RC_6499421cde34cd32d316edf8d06cbcc2();
}

public T[] ToArray<T>(Func<RC_6499421cde34cd32d316edf8d06cbcc2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_78b3e460b8ee2b86cce012a668c82ef2 recordList, Func<RC_6499421cde34cd32d316edf8d06cbcc2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_78b3e460b8ee2b86cce012a668c82ef2(RC_6499421cde34cd32d316edf8d06cbcc2[] array) {
  RL_78b3e460b8ee2b86cce012a668c82ef2 result = new RL_78b3e460b8ee2b86cce012a668c82ef2();
result.InnerFromArray(array);
    return result;
}

public static RL_78b3e460b8ee2b86cce012a668c82ef2 ToList<T>(T[] array, Func <T, RC_6499421cde34cd32d316edf8d06cbcc2> converter) {
  RL_78b3e460b8ee2b86cce012a668c82ef2 result = new RL_78b3e460b8ee2b86cce012a668c82ef2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_78b3e460b8ee2b86cce012a668c82ef2 FromRestList<T>(RestList<T> restList, Func <T, RC_6499421cde34cd32d316edf8d06cbcc2> converter) {
  RL_78b3e460b8ee2b86cce012a668c82ef2 result = new RL_78b3e460b8ee2b86cce012a668c82ef2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_78b3e460b8ee2b86cce012a668c82ef2() : base() {
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
protected override OSList<RC_6499421cde34cd32d316edf8d06cbcc2> NewList() {
return new RL_78b3e460b8ee2b86cce012a668c82ef2();
}


} // RL_78b3e460b8ee2b86cce012a668c82ef2
}

