namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXFFIMF_RETEN_PROVEEDORESResp (S5bB4Wf+MUeTUairnxWccg)
///  <code>ST_b29967856499aeaa8c796dc87fe4c6e8Structure</code> that represent
/// s <code>ZMXFFIMF_RETEN_PROVEEDORESResp</code> <p>Description: ZMXFFIMF_RETEN_PROVEEDORESResp</p>
/// </summary>
// Name: ZMXFFIMF_RETEN_PROVEEDORESResp
public partial struct ST_b29967856499aeaa8c796dc87fe4c6e8Structure : ITypedRecord<ST_b29967856499aeaa8c796dc87fe4c6e8Structure> {
internal static readonly GlobalObjectKey IdPO_RESPUESTA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*n3Nf1rPTZUChkbsEMpnr+A");
internal static readonly GlobalObjectKey IdTI_RETENCIONES_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*KVjYNCKZVEaMvSKwm74ibA");

public string ssPO_RESPUESTA;

public RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd ssTI_RETENCIONES_Out;


public BitArray OptimizedAttributes;

public ST_b29967856499aeaa8c796dc87fe4c6e8Structure() {
OptimizedAttributes = null;
ssPO_RESPUESTA = "";
ssTI_RETENCIONES_Out = new RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd();
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
ssPO_RESPUESTA = r.ReadText(index++, "ZMXFFIMF_RETEN_PROVEEDORESResp.PO_RESPUESTA", "");
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
public void ReadIM(ST_b29967856499aeaa8c796dc87fe4c6e8Structure r) {
this = r;
}


public static bool operator == (ST_b29967856499aeaa8c796dc87fe4c6e8Structure a, ST_b29967856499aeaa8c796dc87fe4c6e8Structure b) {
if (a.ssPO_RESPUESTA != b.ssPO_RESPUESTA) return false;
if (a.ssTI_RETENCIONES_Out != b.ssTI_RETENCIONES_Out) return false;
return true;
}

public static bool operator != (ST_b29967856499aeaa8c796dc87fe4c6e8Structure a, ST_b29967856499aeaa8c796dc87fe4c6e8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b29967856499aeaa8c796dc87fe4c6e8Structure)) return false;
return (this == (ST_b29967856499aeaa8c796dc87fe4c6e8Structure)o);
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


public ST_b29967856499aeaa8c796dc87fe4c6e8Structure Duplicate() {
ST_b29967856499aeaa8c796dc87fe4c6e8Structure t;
t.ssPO_RESPUESTA = this.ssPO_RESPUESTA;
t.ssTI_RETENCIONES_Out = (RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd)this.ssTI_RETENCIONES_Out.Duplicate();
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
ssTI_RETENCIONES_Out = new RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd();
ssTI_RETENCIONES_Out.FillFromOther((IOSList) other.AttributeGet(IdTI_RETENCIONES_Out));
}
} // ST_b29967856499aeaa8c796dc87fe4c6e8Structure
/// <summary>
/// RecordList type <code>ZMXFFIMF_RETEN_PROVEEDORESRespList</code> that represents a record list of
///  <code>ZMXFFIMF_RETEN_PROVEEDORESResp</code>
/// </summary>
public partial class RL_dc874c0ef064697414e5241a1cf0d522 : GenericRecordList<ST_b29967856499aeaa8c796dc87fe4c6e8Structure>, IEnumerable, IEnumerator {

protected override ST_b29967856499aeaa8c796dc87fe4c6e8Structure GetElementDefaultValue() {
return new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();
}

public T[] ToArray<T>(Func<ST_b29967856499aeaa8c796dc87fe4c6e8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dc874c0ef064697414e5241a1cf0d522 recordList, Func<ST_b29967856499aeaa8c796dc87fe4c6e8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dc874c0ef064697414e5241a1cf0d522(ST_b29967856499aeaa8c796dc87fe4c6e8Structure[] array) {
  RL_dc874c0ef064697414e5241a1cf0d522 result = new RL_dc874c0ef064697414e5241a1cf0d522();
result.InnerFromArray(array);
    return result;
}

public static RL_dc874c0ef064697414e5241a1cf0d522 ToList<T>(T[] array, Func <T, ST_b29967856499aeaa8c796dc87fe4c6e8Structure> converter) {
  RL_dc874c0ef064697414e5241a1cf0d522 result = new RL_dc874c0ef064697414e5241a1cf0d522();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dc874c0ef064697414e5241a1cf0d522 FromRestList<T>(RestList<T> restList, Func <T, ST_b29967856499aeaa8c796dc87fe4c6e8Structure> converter) {
  RL_dc874c0ef064697414e5241a1cf0d522 result = new RL_dc874c0ef064697414e5241a1cf0d522();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dc874c0ef064697414e5241a1cf0d522() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b29967856499aeaa8c796dc87fe4c6e8Structure> NewList() {
return new RL_dc874c0ef064697414e5241a1cf0d522();
}


} // RL_dc874c0ef064697414e5241a1cf0d522
}

