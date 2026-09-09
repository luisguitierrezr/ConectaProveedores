namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_GENERA_PEDIDO_PDFReq (6WTZXr61CUitjsVhYMOwrg)
///  <code>ST_7ddccdeb65a44283541a52358876da04Structure</code> that represent
/// s <code>ZMXMIMMF_GENERA_PEDIDO_PDFReq</code> <p>Description: ZMXMIMMF_GENERA_PEDIDO_PDFReq</p>
/// </summary>
// Name: ZMXMIMMF_GENERA_PEDIDO_PDFReq
public partial struct ST_7ddccdeb65a44283541a52358876da04Structure : ITypedRecord<ST_7ddccdeb65a44283541a52358876da04Structure> {
internal static readonly GlobalObjectKey IdPI_PEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*lDe2uhAA0ESpGX1fAOZzfQ");

public string ssPI_PEDIDO;


public BitArray OptimizedAttributes;

public ST_7ddccdeb65a44283541a52358876da04Structure() {
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
ssPI_PEDIDO = r.ReadText(index++, "ZMXMIMMF_GENERA_PEDIDO_PDFReq.PI_PEDIDO", "");
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
public void ReadIM(ST_7ddccdeb65a44283541a52358876da04Structure r) {
this = r;
}


public static bool operator == (ST_7ddccdeb65a44283541a52358876da04Structure a, ST_7ddccdeb65a44283541a52358876da04Structure b) {
if (a.ssPI_PEDIDO != b.ssPI_PEDIDO) return false;
return true;
}

public static bool operator != (ST_7ddccdeb65a44283541a52358876da04Structure a, ST_7ddccdeb65a44283541a52358876da04Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7ddccdeb65a44283541a52358876da04Structure)) return false;
return (this == (ST_7ddccdeb65a44283541a52358876da04Structure)o);
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


public ST_7ddccdeb65a44283541a52358876da04Structure Duplicate() {
ST_7ddccdeb65a44283541a52358876da04Structure t;
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
} // ST_7ddccdeb65a44283541a52358876da04Structure
/// <summary>
/// RecordList type <code>ZMXMIMMF_GENERA_PEDIDO_PDFReqList</code> that represents a record list of
///  <code>ZMXMIMMF_GENERA_PEDIDO_PDFReq</code>
/// </summary>
public partial class RL_31b52649c9e256b3885a3a61e4d7c0d7 : GenericRecordList<ST_7ddccdeb65a44283541a52358876da04Structure>, IEnumerable, IEnumerator {

protected override ST_7ddccdeb65a44283541a52358876da04Structure GetElementDefaultValue() {
return new ST_7ddccdeb65a44283541a52358876da04Structure();
}

public T[] ToArray<T>(Func<ST_7ddccdeb65a44283541a52358876da04Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_31b52649c9e256b3885a3a61e4d7c0d7 recordList, Func<ST_7ddccdeb65a44283541a52358876da04Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_31b52649c9e256b3885a3a61e4d7c0d7(ST_7ddccdeb65a44283541a52358876da04Structure[] array) {
  RL_31b52649c9e256b3885a3a61e4d7c0d7 result = new RL_31b52649c9e256b3885a3a61e4d7c0d7();
result.InnerFromArray(array);
    return result;
}

public static RL_31b52649c9e256b3885a3a61e4d7c0d7 ToList<T>(T[] array, Func <T, ST_7ddccdeb65a44283541a52358876da04Structure> converter) {
  RL_31b52649c9e256b3885a3a61e4d7c0d7 result = new RL_31b52649c9e256b3885a3a61e4d7c0d7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_31b52649c9e256b3885a3a61e4d7c0d7 FromRestList<T>(RestList<T> restList, Func <T, ST_7ddccdeb65a44283541a52358876da04Structure> converter) {
  RL_31b52649c9e256b3885a3a61e4d7c0d7 result = new RL_31b52649c9e256b3885a3a61e4d7c0d7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_31b52649c9e256b3885a3a61e4d7c0d7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7ddccdeb65a44283541a52358876da04Structure> NewList() {
return new RL_31b52649c9e256b3885a3a61e4d7c0d7();
}


} // RL_31b52649c9e256b3885a3a61e4d7c0d7
}

