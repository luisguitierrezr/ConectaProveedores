namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_VISUALIZAR_SAL_ANTReq (F_y4KwFT1EioCbAxnZ72Fw)
///  <code>ST_f68ab54e767928bb7cc21e9801e8642bStructure</code> that represent
/// s <code>ZMXMIMMF_VISUALIZAR_SAL_ANTReq</code> <p>Description: ZMXMIMMF_VISUALIZAR_SAL_ANTReq</p>
/// </summary>
// Name: ZMXMIMMF_VISUALIZAR_SAL_ANTReq
public partial struct ST_f68ab54e767928bb7cc21e9801e8642bStructure : ITypedRecord<ST_f68ab54e767928bb7cc21e9801e8642bStructure> {
internal static readonly GlobalObjectKey IdPI_PEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*vugHz_obvUGS38J0hhRDxg");

public string ssPI_PEDIDO;


public BitArray OptimizedAttributes;

public ST_f68ab54e767928bb7cc21e9801e8642bStructure() {
OptimizedAttributes = null;
ssPI_PEDIDO = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPI_PEDIDO = r.ReadText(index++, "ZMXMIMMF_VISUALIZAR_SAL_ANTReq.PI_PEDIDO", "");
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
public void ReadIM(ST_f68ab54e767928bb7cc21e9801e8642bStructure r) {
this = r;
}


public static bool operator == (ST_f68ab54e767928bb7cc21e9801e8642bStructure a, ST_f68ab54e767928bb7cc21e9801e8642bStructure b) {
if (a.ssPI_PEDIDO != b.ssPI_PEDIDO) return false;
return true;
}

public static bool operator != (ST_f68ab54e767928bb7cc21e9801e8642bStructure a, ST_f68ab54e767928bb7cc21e9801e8642bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f68ab54e767928bb7cc21e9801e8642bStructure)) return false;
return (this == (ST_f68ab54e767928bb7cc21e9801e8642bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_PEDIDO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f68ab54e767928bb7cc21e9801e8642bStructure Duplicate() {
ST_f68ab54e767928bb7cc21e9801e8642bStructure t;
t.ssPI_PEDIDO = this.ssPI_PEDIDO;
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
if (head == "pi_pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_PEDIDO")) variable.Value = ssPI_PEDIDO; else variable.Optimized = true;
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
if (key == IdPI_PEDIDO) {
return ssPI_PEDIDO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_PEDIDO.Key.AsGuid) {
return ssPI_PEDIDO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_PEDIDO = (string) other.AttributeGet(IdPI_PEDIDO);
}
} // ST_f68ab54e767928bb7cc21e9801e8642bStructure
/// <summary>
/// RecordList type <code>ZMXMIMMF_VISUALIZAR_SAL_ANTReqList</code> that represents a record list of
///  <code>ZMXMIMMF_VISUALIZAR_SAL_ANTReq</code>
/// </summary>
public partial class RL_11f02c3e1791f2dd4a2552975c7f1359 : GenericRecordList<ST_f68ab54e767928bb7cc21e9801e8642bStructure>, IEnumerable, IEnumerator {

protected override ST_f68ab54e767928bb7cc21e9801e8642bStructure GetElementDefaultValue() {
return new ST_f68ab54e767928bb7cc21e9801e8642bStructure();
}

public T[] ToArray<T>(Func<ST_f68ab54e767928bb7cc21e9801e8642bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_11f02c3e1791f2dd4a2552975c7f1359 recordList, Func<ST_f68ab54e767928bb7cc21e9801e8642bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_11f02c3e1791f2dd4a2552975c7f1359(ST_f68ab54e767928bb7cc21e9801e8642bStructure[] array) {
  RL_11f02c3e1791f2dd4a2552975c7f1359 result = new RL_11f02c3e1791f2dd4a2552975c7f1359();
result.InnerFromArray(array);
    return result;
}

public static RL_11f02c3e1791f2dd4a2552975c7f1359 ToList<T>(T[] array, Func <T, ST_f68ab54e767928bb7cc21e9801e8642bStructure> converter) {
  RL_11f02c3e1791f2dd4a2552975c7f1359 result = new RL_11f02c3e1791f2dd4a2552975c7f1359();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_11f02c3e1791f2dd4a2552975c7f1359 FromRestList<T>(RestList<T> restList, Func <T, ST_f68ab54e767928bb7cc21e9801e8642bStructure> converter) {
  RL_11f02c3e1791f2dd4a2552975c7f1359 result = new RL_11f02c3e1791f2dd4a2552975c7f1359();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_11f02c3e1791f2dd4a2552975c7f1359() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f68ab54e767928bb7cc21e9801e8642bStructure> NewList() {
return new RL_11f02c3e1791f2dd4a2552975c7f1359();
}


} // RL_11f02c3e1791f2dd4a2552975c7f1359
}

