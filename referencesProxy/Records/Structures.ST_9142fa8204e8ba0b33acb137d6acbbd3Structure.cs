namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_EM_COSMOZResp (nU9NdojBVUOF+Q7s0il35Q)
///  <code>ST_9142fa8204e8ba0b33acb137d6acbbd3Structure</code> that represent
/// s <code>ZMXMIMMF_EM_COSMOZResp</code> <p>Description: ZMXMIMMF_EM_COSMOZResp</p>
/// </summary>
// Name: ZMXMIMMF_EM_COSMOZResp
public partial struct ST_9142fa8204e8ba0b33acb137d6acbbd3Structure : ITypedRecord<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure> {
internal static readonly GlobalObjectKey IdPO_DESCRIPCION_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*AAxo1FyGU0OgLaywj8J2Mg");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*wCPbQtLW7UGrslGV5NDoaw");
internal static readonly GlobalObjectKey IdPO_EJERCICIO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*WcCNtQ5n3EmagyUPzLC1PA");
internal static readonly GlobalObjectKey IdPO_NUMERO_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Z7CKkepgjEW9pxCUFCzr_A");
internal static readonly GlobalObjectKey IdPO_RESULTADO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*SMB_DgzDxk6VtOXs5IpnbA");

public string ssPO_DESCRIPCION_ERROR;

public string ssPO_DOCUMENTO_MATERIAL;

public string ssPO_EJERCICIO;

public string ssPO_NUMERO_ERROR;

public string ssPO_RESULTADO;


public BitArray OptimizedAttributes;

public ST_9142fa8204e8ba0b33acb137d6acbbd3Structure() {
OptimizedAttributes = null;
ssPO_DESCRIPCION_ERROR = "";
ssPO_DOCUMENTO_MATERIAL = "";
ssPO_EJERCICIO = "";
ssPO_NUMERO_ERROR = "";
ssPO_RESULTADO = "";
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
ssPO_DESCRIPCION_ERROR = r.ReadText(index++, "ZMXMIMMF_EM_COSMOZResp.PO_DESCRIPCION_ERROR", "");
ssPO_DOCUMENTO_MATERIAL = r.ReadText(index++, "ZMXMIMMF_EM_COSMOZResp.PO_DOCUMENTO_MATERIAL", "");
ssPO_EJERCICIO = r.ReadText(index++, "ZMXMIMMF_EM_COSMOZResp.PO_EJERCICIO", "");
ssPO_NUMERO_ERROR = r.ReadText(index++, "ZMXMIMMF_EM_COSMOZResp.PO_NUMERO_ERROR", "");
ssPO_RESULTADO = r.ReadText(index++, "ZMXMIMMF_EM_COSMOZResp.PO_RESULTADO", "");
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
public void ReadIM(ST_9142fa8204e8ba0b33acb137d6acbbd3Structure r) {
this = r;
}


public static bool operator == (ST_9142fa8204e8ba0b33acb137d6acbbd3Structure a, ST_9142fa8204e8ba0b33acb137d6acbbd3Structure b) {
if (a.ssPO_DESCRIPCION_ERROR != b.ssPO_DESCRIPCION_ERROR) return false;
if (a.ssPO_DOCUMENTO_MATERIAL != b.ssPO_DOCUMENTO_MATERIAL) return false;
if (a.ssPO_EJERCICIO != b.ssPO_EJERCICIO) return false;
if (a.ssPO_NUMERO_ERROR != b.ssPO_NUMERO_ERROR) return false;
if (a.ssPO_RESULTADO != b.ssPO_RESULTADO) return false;
return true;
}

public static bool operator != (ST_9142fa8204e8ba0b33acb137d6acbbd3Structure a, ST_9142fa8204e8ba0b33acb137d6acbbd3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9142fa8204e8ba0b33acb137d6acbbd3Structure)) return false;
return (this == (ST_9142fa8204e8ba0b33acb137d6acbbd3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPO_DESCRIPCION_ERROR.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL.GetHashCode()
 ^ ssPO_EJERCICIO.GetHashCode()
 ^ ssPO_NUMERO_ERROR.GetHashCode()
 ^ ssPO_RESULTADO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_9142fa8204e8ba0b33acb137d6acbbd3Structure Duplicate() {
ST_9142fa8204e8ba0b33acb137d6acbbd3Structure t;
t.ssPO_DESCRIPCION_ERROR = this.ssPO_DESCRIPCION_ERROR;
t.ssPO_DOCUMENTO_MATERIAL = this.ssPO_DOCUMENTO_MATERIAL;
t.ssPO_EJERCICIO = this.ssPO_EJERCICIO;
t.ssPO_NUMERO_ERROR = this.ssPO_NUMERO_ERROR;
t.ssPO_RESULTADO = this.ssPO_RESULTADO;
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
if (head == "po_descripcion_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DESCRIPCION_ERROR")) variable.Value = ssPO_DESCRIPCION_ERROR; else variable.Optimized = true;
} else if (head == "po_documento_material") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL")) variable.Value = ssPO_DOCUMENTO_MATERIAL; else variable.Optimized = true;
} else if (head == "po_ejercicio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO")) variable.Value = ssPO_EJERCICIO; else variable.Optimized = true;
} else if (head == "po_numero_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_NUMERO_ERROR")) variable.Value = ssPO_NUMERO_ERROR; else variable.Optimized = true;
} else if (head == "po_resultado") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_RESULTADO")) variable.Value = ssPO_RESULTADO; else variable.Optimized = true;
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
if (key == IdPO_DESCRIPCION_ERROR) {
return ssPO_DESCRIPCION_ERROR;
}
if (key == IdPO_DOCUMENTO_MATERIAL) {
return ssPO_DOCUMENTO_MATERIAL;
}
if (key == IdPO_EJERCICIO) {
return ssPO_EJERCICIO;
}
if (key == IdPO_NUMERO_ERROR) {
return ssPO_NUMERO_ERROR;
}
if (key == IdPO_RESULTADO) {
return ssPO_RESULTADO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPO_DESCRIPCION_ERROR.Key.AsGuid) {
return ssPO_DESCRIPCION_ERROR;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL;
}
if (attributeKey == IdPO_EJERCICIO.Key.AsGuid) {
return ssPO_EJERCICIO;
}
if (attributeKey == IdPO_NUMERO_ERROR.Key.AsGuid) {
return ssPO_NUMERO_ERROR;
}
if (attributeKey == IdPO_RESULTADO.Key.AsGuid) {
return ssPO_RESULTADO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPO_DESCRIPCION_ERROR = (string) other.AttributeGet(IdPO_DESCRIPCION_ERROR);
ssPO_DOCUMENTO_MATERIAL = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL);
ssPO_EJERCICIO = (string) other.AttributeGet(IdPO_EJERCICIO);
ssPO_NUMERO_ERROR = (string) other.AttributeGet(IdPO_NUMERO_ERROR);
ssPO_RESULTADO = (string) other.AttributeGet(IdPO_RESULTADO);
}
} // ST_9142fa8204e8ba0b33acb137d6acbbd3Structure
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_COSMOZRespList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_COSMOZResp</code>
/// </summary>
public partial class RL_052c43b4173649baefb45bfffd7986db : GenericRecordList<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure>, IEnumerable, IEnumerator {

protected override ST_9142fa8204e8ba0b33acb137d6acbbd3Structure GetElementDefaultValue() {
return new ST_9142fa8204e8ba0b33acb137d6acbbd3Structure();
}

public T[] ToArray<T>(Func<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_052c43b4173649baefb45bfffd7986db recordList, Func<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_052c43b4173649baefb45bfffd7986db(ST_9142fa8204e8ba0b33acb137d6acbbd3Structure[] array) {
  RL_052c43b4173649baefb45bfffd7986db result = new RL_052c43b4173649baefb45bfffd7986db();
result.InnerFromArray(array);
    return result;
}

public static RL_052c43b4173649baefb45bfffd7986db ToList<T>(T[] array, Func <T, ST_9142fa8204e8ba0b33acb137d6acbbd3Structure> converter) {
  RL_052c43b4173649baefb45bfffd7986db result = new RL_052c43b4173649baefb45bfffd7986db();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_052c43b4173649baefb45bfffd7986db FromRestList<T>(RestList<T> restList, Func <T, ST_9142fa8204e8ba0b33acb137d6acbbd3Structure> converter) {
  RL_052c43b4173649baefb45bfffd7986db result = new RL_052c43b4173649baefb45bfffd7986db();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_052c43b4173649baefb45bfffd7986db() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure> NewList() {
return new RL_052c43b4173649baefb45bfffd7986db();
}


} // RL_052c43b4173649baefb45bfffd7986db
}

