namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_EM_SM_MO_COSMOZResp (0BoQrSusSkelHpFLZI9RJA)
///  <code>ST_39fca1fbc45889b86a3f10d9a278767bStructure</code> that represent
/// s <code>ZMXMIMMF_EM_SM_MO_COSMOZResp</code> <p>Description: ZMXMIMMF_EM_SM_MO_COSMOZResp</p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_MO_COSMOZResp
public partial struct ST_39fca1fbc45889b86a3f10d9a278767bStructure : ITypedRecord<ST_39fca1fbc45889b86a3f10d9a278767bStructure> {
internal static readonly GlobalObjectKey IdPO_DESCRIPCION_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*YznQRGnXWEmeqKcRhs8SCQ");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_221 = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*blr2K9_Jy0C1oLK1xbAkOw");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_415 = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*RMix2s6HNkepn43ibkTmvg");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*2kl2gp6uuUGwoOJcOijwLw");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_221 = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*7Sq4os6ECE2TjwkTxc5EUQ");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_415 = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Tb7WrESZn0GqZStpjwpXFA");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*rrkf5GbqD0Gi5h5aC3fmBA");
internal static readonly GlobalObjectKey IdPO_NUMERO_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*kCeu_4j0OUWeaj4R5Dno0A");
internal static readonly GlobalObjectKey IdPO_RESULTADO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*uwBQaafDFUi6jPYMTxKNuw");

public string ssPO_DESCRIPCION_ERROR;

public string ssPO_DOCUMENTO_MATERIAL_221;

public string ssPO_DOCUMENTO_MATERIAL_415;

public string ssPO_DOCUMENTO_MATERIAL_EM;

public int ssPO_EJERCICIO_221;

public int ssPO_EJERCICIO_415;

public int ssPO_EJERCICIO_EM;

public int ssPO_NUMERO_ERROR;

public string ssPO_RESULTADO;


public BitArray OptimizedAttributes;

public ST_39fca1fbc45889b86a3f10d9a278767bStructure() {
OptimizedAttributes = null;
ssPO_DESCRIPCION_ERROR = "";
ssPO_DOCUMENTO_MATERIAL_221 = "";
ssPO_DOCUMENTO_MATERIAL_415 = "";
ssPO_DOCUMENTO_MATERIAL_EM = "";
ssPO_EJERCICIO_221 = 0;
ssPO_EJERCICIO_415 = 0;
ssPO_EJERCICIO_EM = 0;
ssPO_NUMERO_ERROR = 0;
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
ssPO_DESCRIPCION_ERROR = r.ReadText(index++, "ZMXMIMMF_EM_SM_MO_COSMOZResp.PO_DESCRIPCION_ERROR", "");
ssPO_DOCUMENTO_MATERIAL_221 = r.ReadText(index++, "ZMXMIMMF_EM_SM_MO_COSMOZResp.PO_DOCUMENTO_MATERIAL_221", "");
ssPO_DOCUMENTO_MATERIAL_415 = r.ReadText(index++, "ZMXMIMMF_EM_SM_MO_COSMOZResp.PO_DOCUMENTO_MATERIAL_415", "");
ssPO_DOCUMENTO_MATERIAL_EM = r.ReadText(index++, "ZMXMIMMF_EM_SM_MO_COSMOZResp.PO_DOCUMENTO_MATERIAL_EM", "");
ssPO_EJERCICIO_221 = r.ReadInteger(index++, "ZMXMIMMF_EM_SM_MO_COSMOZResp.PO_EJERCICIO_221", 0);
ssPO_EJERCICIO_415 = r.ReadInteger(index++, "ZMXMIMMF_EM_SM_MO_COSMOZResp.PO_EJERCICIO_415", 0);
ssPO_EJERCICIO_EM = r.ReadInteger(index++, "ZMXMIMMF_EM_SM_MO_COSMOZResp.PO_EJERCICIO_EM", 0);
ssPO_NUMERO_ERROR = r.ReadInteger(index++, "ZMXMIMMF_EM_SM_MO_COSMOZResp.PO_NUMERO_ERROR", 0);
ssPO_RESULTADO = r.ReadText(index++, "ZMXMIMMF_EM_SM_MO_COSMOZResp.PO_RESULTADO", "");
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
public void ReadIM(ST_39fca1fbc45889b86a3f10d9a278767bStructure r) {
this = r;
}


public static bool operator == (ST_39fca1fbc45889b86a3f10d9a278767bStructure a, ST_39fca1fbc45889b86a3f10d9a278767bStructure b) {
if (a.ssPO_DESCRIPCION_ERROR != b.ssPO_DESCRIPCION_ERROR) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_221 != b.ssPO_DOCUMENTO_MATERIAL_221) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_415 != b.ssPO_DOCUMENTO_MATERIAL_415) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_EM != b.ssPO_DOCUMENTO_MATERIAL_EM) return false;
if (a.ssPO_EJERCICIO_221 != b.ssPO_EJERCICIO_221) return false;
if (a.ssPO_EJERCICIO_415 != b.ssPO_EJERCICIO_415) return false;
if (a.ssPO_EJERCICIO_EM != b.ssPO_EJERCICIO_EM) return false;
if (a.ssPO_NUMERO_ERROR != b.ssPO_NUMERO_ERROR) return false;
if (a.ssPO_RESULTADO != b.ssPO_RESULTADO) return false;
return true;
}

public static bool operator != (ST_39fca1fbc45889b86a3f10d9a278767bStructure a, ST_39fca1fbc45889b86a3f10d9a278767bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_39fca1fbc45889b86a3f10d9a278767bStructure)) return false;
return (this == (ST_39fca1fbc45889b86a3f10d9a278767bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPO_DESCRIPCION_ERROR.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_221.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_415.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_EM.GetHashCode()
 ^ ssPO_EJERCICIO_221.GetHashCode()
 ^ ssPO_EJERCICIO_415.GetHashCode()
 ^ ssPO_EJERCICIO_EM.GetHashCode()
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


public ST_39fca1fbc45889b86a3f10d9a278767bStructure Duplicate() {
ST_39fca1fbc45889b86a3f10d9a278767bStructure t;
t.ssPO_DESCRIPCION_ERROR = this.ssPO_DESCRIPCION_ERROR;
t.ssPO_DOCUMENTO_MATERIAL_221 = this.ssPO_DOCUMENTO_MATERIAL_221;
t.ssPO_DOCUMENTO_MATERIAL_415 = this.ssPO_DOCUMENTO_MATERIAL_415;
t.ssPO_DOCUMENTO_MATERIAL_EM = this.ssPO_DOCUMENTO_MATERIAL_EM;
t.ssPO_EJERCICIO_221 = this.ssPO_EJERCICIO_221;
t.ssPO_EJERCICIO_415 = this.ssPO_EJERCICIO_415;
t.ssPO_EJERCICIO_EM = this.ssPO_EJERCICIO_EM;
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
} else if (head == "po_documento_material_221") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_221")) variable.Value = ssPO_DOCUMENTO_MATERIAL_221; else variable.Optimized = true;
} else if (head == "po_documento_material_415") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_415")) variable.Value = ssPO_DOCUMENTO_MATERIAL_415; else variable.Optimized = true;
} else if (head == "po_documento_material_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_EM")) variable.Value = ssPO_DOCUMENTO_MATERIAL_EM; else variable.Optimized = true;
} else if (head == "po_ejercicio_221") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_221")) variable.Value = ssPO_EJERCICIO_221; else variable.Optimized = true;
} else if (head == "po_ejercicio_415") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_415")) variable.Value = ssPO_EJERCICIO_415; else variable.Optimized = true;
} else if (head == "po_ejercicio_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_EM")) variable.Value = ssPO_EJERCICIO_EM; else variable.Optimized = true;
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
if (key == IdPO_DOCUMENTO_MATERIAL_221) {
return ssPO_DOCUMENTO_MATERIAL_221;
}
if (key == IdPO_DOCUMENTO_MATERIAL_415) {
return ssPO_DOCUMENTO_MATERIAL_415;
}
if (key == IdPO_DOCUMENTO_MATERIAL_EM) {
return ssPO_DOCUMENTO_MATERIAL_EM;
}
if (key == IdPO_EJERCICIO_221) {
return ssPO_EJERCICIO_221;
}
if (key == IdPO_EJERCICIO_415) {
return ssPO_EJERCICIO_415;
}
if (key == IdPO_EJERCICIO_EM) {
return ssPO_EJERCICIO_EM;
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
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_221.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_221;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_415.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_415;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_EM.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_EM;
}
if (attributeKey == IdPO_EJERCICIO_221.Key.AsGuid) {
return ssPO_EJERCICIO_221;
}
if (attributeKey == IdPO_EJERCICIO_415.Key.AsGuid) {
return ssPO_EJERCICIO_415;
}
if (attributeKey == IdPO_EJERCICIO_EM.Key.AsGuid) {
return ssPO_EJERCICIO_EM;
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
ssPO_DOCUMENTO_MATERIAL_221 = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_221);
ssPO_DOCUMENTO_MATERIAL_415 = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_415);
ssPO_DOCUMENTO_MATERIAL_EM = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_EM);
ssPO_EJERCICIO_221 = (int) other.AttributeGet(IdPO_EJERCICIO_221);
ssPO_EJERCICIO_415 = (int) other.AttributeGet(IdPO_EJERCICIO_415);
ssPO_EJERCICIO_EM = (int) other.AttributeGet(IdPO_EJERCICIO_EM);
ssPO_NUMERO_ERROR = (int) other.AttributeGet(IdPO_NUMERO_ERROR);
ssPO_RESULTADO = (string) other.AttributeGet(IdPO_RESULTADO);
}
} // ST_39fca1fbc45889b86a3f10d9a278767bStructure
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_MO_COSMOZRespList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_SM_MO_COSMOZResp</code>
/// </summary>
public partial class RL_e2e94ef56c242db400c2b5f05d86a6c2 : GenericRecordList<ST_39fca1fbc45889b86a3f10d9a278767bStructure>, IEnumerable, IEnumerator {

protected override ST_39fca1fbc45889b86a3f10d9a278767bStructure GetElementDefaultValue() {
return new ST_39fca1fbc45889b86a3f10d9a278767bStructure();
}

public T[] ToArray<T>(Func<ST_39fca1fbc45889b86a3f10d9a278767bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e2e94ef56c242db400c2b5f05d86a6c2 recordList, Func<ST_39fca1fbc45889b86a3f10d9a278767bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e2e94ef56c242db400c2b5f05d86a6c2(ST_39fca1fbc45889b86a3f10d9a278767bStructure[] array) {
  RL_e2e94ef56c242db400c2b5f05d86a6c2 result = new RL_e2e94ef56c242db400c2b5f05d86a6c2();
result.InnerFromArray(array);
    return result;
}

public static RL_e2e94ef56c242db400c2b5f05d86a6c2 ToList<T>(T[] array, Func <T, ST_39fca1fbc45889b86a3f10d9a278767bStructure> converter) {
  RL_e2e94ef56c242db400c2b5f05d86a6c2 result = new RL_e2e94ef56c242db400c2b5f05d86a6c2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e2e94ef56c242db400c2b5f05d86a6c2 FromRestList<T>(RestList<T> restList, Func <T, ST_39fca1fbc45889b86a3f10d9a278767bStructure> converter) {
  RL_e2e94ef56c242db400c2b5f05d86a6c2 result = new RL_e2e94ef56c242db400c2b5f05d86a6c2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e2e94ef56c242db400c2b5f05d86a6c2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_39fca1fbc45889b86a3f10d9a278767bStructure> NewList() {
return new RL_e2e94ef56c242db400c2b5f05d86a6c2();
}


} // RL_e2e94ef56c242db400c2b5f05d86a6c2
}

