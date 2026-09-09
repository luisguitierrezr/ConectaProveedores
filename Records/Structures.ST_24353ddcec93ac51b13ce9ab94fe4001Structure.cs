namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp (xWn8CRhFv0yRaVmA6MH9hA)
///  <code>ST_24353ddcec93ac51b13ce9ab94fe4001Structure</code> that represent
/// s <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp</code> <p>Description:
///  BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp</p>
/// </summary>
// Name: BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp
public partial struct ST_24353ddcec93ac51b13ce9ab94fe4001Structure : ITypedRecord<ST_24353ddcec93ac51b13ce9ab94fe4001Structure> {
internal static readonly GlobalObjectKey IdPO_RESPUESTA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*no7PLbscWEWo8amq12OfOA");
internal static readonly GlobalObjectKey IdTI_RETENCIONES_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*7VruquaMj02Jx5iteW0QUA");

public string ssPO_RESPUESTA;

public RL_4b72a47efbb84d37cf5e3e0ffb46314d ssTI_RETENCIONES_Out;


public BitArray OptimizedAttributes;

public ST_24353ddcec93ac51b13ce9ab94fe4001Structure() {
OptimizedAttributes = null;
ssPO_RESPUESTA = "";
ssTI_RETENCIONES_Out = new RL_4b72a47efbb84d37cf5e3e0ffb46314d();
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
ssPO_RESPUESTA = r.ReadText(index++, "BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp.PO_RESPUESTA", "");
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
public void ReadIM(ST_24353ddcec93ac51b13ce9ab94fe4001Structure r) {
this = r;
}


public static bool operator == (ST_24353ddcec93ac51b13ce9ab94fe4001Structure a, ST_24353ddcec93ac51b13ce9ab94fe4001Structure b) {
if (a.ssPO_RESPUESTA != b.ssPO_RESPUESTA) return false;
if (a.ssTI_RETENCIONES_Out != b.ssTI_RETENCIONES_Out) return false;
return true;
}

public static bool operator != (ST_24353ddcec93ac51b13ce9ab94fe4001Structure a, ST_24353ddcec93ac51b13ce9ab94fe4001Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_24353ddcec93ac51b13ce9ab94fe4001Structure)) return false;
return (this == (ST_24353ddcec93ac51b13ce9ab94fe4001Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPO_RESPUESTA.GetHashCode()
 ^ ssTI_RETENCIONES_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssTI_RETENCIONES_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssTI_RETENCIONES_Out.InternalRecursiveSave();
}


public ST_24353ddcec93ac51b13ce9ab94fe4001Structure Duplicate() {
ST_24353ddcec93ac51b13ce9ab94fe4001Structure t;
t.ssPO_RESPUESTA = this.ssPO_RESPUESTA;
t.ssTI_RETENCIONES_Out = (RL_4b72a47efbb84d37cf5e3e0ffb46314d)this.ssTI_RETENCIONES_Out.Duplicate();
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
if (head == "po_respuesta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_RESPUESTA")) variable.Value = ssPO_RESPUESTA; else variable.Optimized = true;
} else if (head == "ti_retenciones_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_RETENCIONES_Out")) variable.Value = ssTI_RETENCIONES_Out; else variable.Optimized = true;
variable.SetFieldName("ti_retenciones_out");
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
if (key == IdPO_RESPUESTA) {
return ssPO_RESPUESTA;
}
if (key == IdTI_RETENCIONES_Out) {
return ssTI_RETENCIONES_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPO_RESPUESTA.Key.AsGuid) {
return ssPO_RESPUESTA;
}
if (attributeKey == IdTI_RETENCIONES_Out.Key.AsGuid) {
return ssTI_RETENCIONES_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPO_RESPUESTA = (string) other.AttributeGet(IdPO_RESPUESTA);
ssTI_RETENCIONES_Out = new RL_4b72a47efbb84d37cf5e3e0ffb46314d();
ssTI_RETENCIONES_Out.FillFromOther((IOSList) other.AttributeGet(IdTI_RETENCIONES_Out));
}
} // ST_24353ddcec93ac51b13ce9ab94fe4001Structure
/// <summary>
/// RecordList type <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_RespList</code> that represents a record list
///  of <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp</code>
/// </summary>
public partial class RL_850e82254698ab99a70ccadc97703c4b : GenericRecordList<ST_24353ddcec93ac51b13ce9ab94fe4001Structure>, IEnumerable, IEnumerator {

protected override ST_24353ddcec93ac51b13ce9ab94fe4001Structure GetElementDefaultValue() {
return new ST_24353ddcec93ac51b13ce9ab94fe4001Structure();
}

public T[] ToArray<T>(Func<ST_24353ddcec93ac51b13ce9ab94fe4001Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_850e82254698ab99a70ccadc97703c4b recordList, Func<ST_24353ddcec93ac51b13ce9ab94fe4001Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_850e82254698ab99a70ccadc97703c4b(ST_24353ddcec93ac51b13ce9ab94fe4001Structure[] array) {
  RL_850e82254698ab99a70ccadc97703c4b result = new RL_850e82254698ab99a70ccadc97703c4b();
result.InnerFromArray(array);
    return result;
}

public static RL_850e82254698ab99a70ccadc97703c4b ToList<T>(T[] array, Func <T, ST_24353ddcec93ac51b13ce9ab94fe4001Structure> converter) {
  RL_850e82254698ab99a70ccadc97703c4b result = new RL_850e82254698ab99a70ccadc97703c4b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_850e82254698ab99a70ccadc97703c4b FromRestList<T>(RestList<T> restList, Func <T, ST_24353ddcec93ac51b13ce9ab94fe4001Structure> converter) {
  RL_850e82254698ab99a70ccadc97703c4b result = new RL_850e82254698ab99a70ccadc97703c4b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_850e82254698ab99a70ccadc97703c4b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_24353ddcec93ac51b13ce9ab94fe4001Structure> NewList() {
return new RL_850e82254698ab99a70ccadc97703c4b();
}


} // RL_850e82254698ab99a70ccadc97703c4b
}

