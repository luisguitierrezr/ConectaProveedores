namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_VISUALIZAR_SAL_ANTResp (ZOmU3_8+U0+GsAJgMlv84g)
///  <code>ST_cbb2055cf19f871ed882642269bd43ceStructure</code> that represent
/// s <code>ZMXMIMMF_VISUALIZAR_SAL_ANTResp</code> <p>Description: ZMXMIMMF_VISUALIZAR_SAL_ANTResp</p>
/// </summary>
// Name: ZMXMIMMF_VISUALIZAR_SAL_ANTResp
public partial struct ST_cbb2055cf19f871ed882642269bd43ceStructure : ITypedRecord<ST_cbb2055cf19f871ed882642269bd43ceStructure> {
internal static readonly GlobalObjectKey IdPO_EXITO_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*qkRki5w_+0eGG4t11udysQ");
internal static readonly GlobalObjectKey IdPO_IMP_ANT = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*_CcZto75dkSlTA4JN12ruQ");
internal static readonly GlobalObjectKey IdPO_MENSAJE = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*yASwK_2IBUSTh7vEUhS0Fg");
internal static readonly GlobalObjectKey IdPO_NUM_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*YypOaH7D_0+vRL401OGHRQ");
internal static readonly GlobalObjectKey IdPO_PEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*9aQhxv4Ucku3VisbMLchDA");

public string ssPO_EXITO_ERROR;

public decimal ssPO_IMP_ANT;

public string ssPO_MENSAJE;

public string ssPO_NUM_ERROR;

public string ssPO_PEDIDO;


public BitArray OptimizedAttributes;

public ST_cbb2055cf19f871ed882642269bd43ceStructure() {
OptimizedAttributes = null;
ssPO_EXITO_ERROR = "";
ssPO_IMP_ANT = 0.0M;
ssPO_MENSAJE = "";
ssPO_NUM_ERROR = "";
ssPO_PEDIDO = "";
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
ssPO_EXITO_ERROR = r.ReadText(index++, "ZMXMIMMF_VISUALIZAR_SAL_ANTResp.PO_EXITO_ERROR", "");
ssPO_IMP_ANT = r.ReadDecimal(index++, "ZMXMIMMF_VISUALIZAR_SAL_ANTResp.PO_IMP_ANT", 0.0M);
ssPO_MENSAJE = r.ReadText(index++, "ZMXMIMMF_VISUALIZAR_SAL_ANTResp.PO_MENSAJE", "");
ssPO_NUM_ERROR = r.ReadText(index++, "ZMXMIMMF_VISUALIZAR_SAL_ANTResp.PO_NUM_ERROR", "");
ssPO_PEDIDO = r.ReadText(index++, "ZMXMIMMF_VISUALIZAR_SAL_ANTResp.PO_PEDIDO", "");
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
public void ReadIM(ST_cbb2055cf19f871ed882642269bd43ceStructure r) {
this = r;
}


public static bool operator == (ST_cbb2055cf19f871ed882642269bd43ceStructure a, ST_cbb2055cf19f871ed882642269bd43ceStructure b) {
if (a.ssPO_EXITO_ERROR != b.ssPO_EXITO_ERROR) return false;
if (a.ssPO_IMP_ANT != b.ssPO_IMP_ANT) return false;
if (a.ssPO_MENSAJE != b.ssPO_MENSAJE) return false;
if (a.ssPO_NUM_ERROR != b.ssPO_NUM_ERROR) return false;
if (a.ssPO_PEDIDO != b.ssPO_PEDIDO) return false;
return true;
}

public static bool operator != (ST_cbb2055cf19f871ed882642269bd43ceStructure a, ST_cbb2055cf19f871ed882642269bd43ceStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_cbb2055cf19f871ed882642269bd43ceStructure)) return false;
return (this == (ST_cbb2055cf19f871ed882642269bd43ceStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPO_EXITO_ERROR.GetHashCode()
 ^ ssPO_IMP_ANT.GetHashCode()
 ^ ssPO_MENSAJE.GetHashCode()
 ^ ssPO_NUM_ERROR.GetHashCode()
 ^ ssPO_PEDIDO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_cbb2055cf19f871ed882642269bd43ceStructure Duplicate() {
ST_cbb2055cf19f871ed882642269bd43ceStructure t;
t.ssPO_EXITO_ERROR = this.ssPO_EXITO_ERROR;
t.ssPO_IMP_ANT = this.ssPO_IMP_ANT;
t.ssPO_MENSAJE = this.ssPO_MENSAJE;
t.ssPO_NUM_ERROR = this.ssPO_NUM_ERROR;
t.ssPO_PEDIDO = this.ssPO_PEDIDO;
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
if (head == "po_exito_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EXITO_ERROR")) variable.Value = ssPO_EXITO_ERROR; else variable.Optimized = true;
} else if (head == "po_imp_ant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_IMP_ANT")) variable.Value = ssPO_IMP_ANT; else variable.Optimized = true;
} else if (head == "po_mensaje") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_MENSAJE")) variable.Value = ssPO_MENSAJE; else variable.Optimized = true;
} else if (head == "po_num_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_NUM_ERROR")) variable.Value = ssPO_NUM_ERROR; else variable.Optimized = true;
} else if (head == "po_pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_PEDIDO")) variable.Value = ssPO_PEDIDO; else variable.Optimized = true;
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
if (key == IdPO_EXITO_ERROR) {
return ssPO_EXITO_ERROR;
}
if (key == IdPO_IMP_ANT) {
return ssPO_IMP_ANT;
}
if (key == IdPO_MENSAJE) {
return ssPO_MENSAJE;
}
if (key == IdPO_NUM_ERROR) {
return ssPO_NUM_ERROR;
}
if (key == IdPO_PEDIDO) {
return ssPO_PEDIDO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPO_EXITO_ERROR.Key.AsGuid) {
return ssPO_EXITO_ERROR;
}
if (attributeKey == IdPO_IMP_ANT.Key.AsGuid) {
return ssPO_IMP_ANT;
}
if (attributeKey == IdPO_MENSAJE.Key.AsGuid) {
return ssPO_MENSAJE;
}
if (attributeKey == IdPO_NUM_ERROR.Key.AsGuid) {
return ssPO_NUM_ERROR;
}
if (attributeKey == IdPO_PEDIDO.Key.AsGuid) {
return ssPO_PEDIDO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPO_EXITO_ERROR = (string) other.AttributeGet(IdPO_EXITO_ERROR);
ssPO_IMP_ANT = (decimal) other.AttributeGet(IdPO_IMP_ANT);
ssPO_MENSAJE = (string) other.AttributeGet(IdPO_MENSAJE);
ssPO_NUM_ERROR = (string) other.AttributeGet(IdPO_NUM_ERROR);
ssPO_PEDIDO = (string) other.AttributeGet(IdPO_PEDIDO);
}
} // ST_cbb2055cf19f871ed882642269bd43ceStructure
/// <summary>
/// RecordList type <code>ZMXMIMMF_VISUALIZAR_SAL_ANTRespList</code> that represents a record list of
///  <code>ZMXMIMMF_VISUALIZAR_SAL_ANTResp</code>
/// </summary>
public partial class RL_2a2f819d8168950a0e08118d5f3d69af : GenericRecordList<ST_cbb2055cf19f871ed882642269bd43ceStructure>, IEnumerable, IEnumerator {

protected override ST_cbb2055cf19f871ed882642269bd43ceStructure GetElementDefaultValue() {
return new ST_cbb2055cf19f871ed882642269bd43ceStructure();
}

public T[] ToArray<T>(Func<ST_cbb2055cf19f871ed882642269bd43ceStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2a2f819d8168950a0e08118d5f3d69af recordList, Func<ST_cbb2055cf19f871ed882642269bd43ceStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2a2f819d8168950a0e08118d5f3d69af(ST_cbb2055cf19f871ed882642269bd43ceStructure[] array) {
  RL_2a2f819d8168950a0e08118d5f3d69af result = new RL_2a2f819d8168950a0e08118d5f3d69af();
result.InnerFromArray(array);
    return result;
}

public static RL_2a2f819d8168950a0e08118d5f3d69af ToList<T>(T[] array, Func <T, ST_cbb2055cf19f871ed882642269bd43ceStructure> converter) {
  RL_2a2f819d8168950a0e08118d5f3d69af result = new RL_2a2f819d8168950a0e08118d5f3d69af();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2a2f819d8168950a0e08118d5f3d69af FromRestList<T>(RestList<T> restList, Func <T, ST_cbb2055cf19f871ed882642269bd43ceStructure> converter) {
  RL_2a2f819d8168950a0e08118d5f3d69af result = new RL_2a2f819d8168950a0e08118d5f3d69af();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2a2f819d8168950a0e08118d5f3d69af() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_cbb2055cf19f871ed882642269bd43ceStructure> NewList() {
return new RL_2a2f819d8168950a0e08118d5f3d69af();
}


} // RL_2a2f819d8168950a0e08118d5f3d69af
}

