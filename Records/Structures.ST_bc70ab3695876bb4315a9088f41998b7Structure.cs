namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_GENERA_PEDIDO_PDFResp (eF1TbipTLkSf8LIAGLRN7Q)
///  <code>ST_bc70ab3695876bb4315a9088f41998b7Structure</code> that represent
/// s <code>ZMXMIMMF_GENERA_PEDIDO_PDFResp</code> <p>Description: ZMXMIMMF_GENERA_PEDIDO_PDFResp</p>
/// </summary>
// Name: ZMXMIMMF_GENERA_PEDIDO_PDFResp
public partial struct ST_bc70ab3695876bb4315a9088f41998b7Structure : ITypedRecord<ST_bc70ab3695876bb4315a9088f41998b7Structure> {
internal static readonly GlobalObjectKey IdPO_DESCRIPCION_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*YmrmLqwkikCGk4g8vtmA0A");
internal static readonly GlobalObjectKey IdPO_NUMERO_ERROR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*L1pF9AuTRUS3GmuQ7sKz6w");
internal static readonly GlobalObjectKey IdPO_PDF = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Z66dtGlyVU6U1a8YP84eTA");
internal static readonly GlobalObjectKey IdPO_RESULTADO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*HRSaPqTBpUup4PWRiyrwJQ");

public string ssPO_DESCRIPCION_ERROR;

public int ssPO_NUMERO_ERROR;

public string ssPO_PDF;

public string ssPO_RESULTADO;


public BitArray OptimizedAttributes;

public ST_bc70ab3695876bb4315a9088f41998b7Structure() {
OptimizedAttributes = null;
ssPO_DESCRIPCION_ERROR = "";
ssPO_NUMERO_ERROR = 0;
ssPO_PDF = "";
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
ssPO_DESCRIPCION_ERROR = r.ReadText(index++, "ZMXMIMMF_GENERA_PEDIDO_PDFResp.PO_DESCRIPCION_ERROR", "");
ssPO_NUMERO_ERROR = r.ReadInteger(index++, "ZMXMIMMF_GENERA_PEDIDO_PDFResp.PO_NUMERO_ERROR", 0);
ssPO_PDF = r.ReadText(index++, "ZMXMIMMF_GENERA_PEDIDO_PDFResp.PO_PDF", "");
ssPO_RESULTADO = r.ReadText(index++, "ZMXMIMMF_GENERA_PEDIDO_PDFResp.PO_RESULTADO", "");
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
public void ReadIM(ST_bc70ab3695876bb4315a9088f41998b7Structure r) {
this = r;
}


public static bool operator == (ST_bc70ab3695876bb4315a9088f41998b7Structure a, ST_bc70ab3695876bb4315a9088f41998b7Structure b) {
if (a.ssPO_DESCRIPCION_ERROR != b.ssPO_DESCRIPCION_ERROR) return false;
if (a.ssPO_NUMERO_ERROR != b.ssPO_NUMERO_ERROR) return false;
if (a.ssPO_PDF != b.ssPO_PDF) return false;
if (a.ssPO_RESULTADO != b.ssPO_RESULTADO) return false;
return true;
}

public static bool operator != (ST_bc70ab3695876bb4315a9088f41998b7Structure a, ST_bc70ab3695876bb4315a9088f41998b7Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_bc70ab3695876bb4315a9088f41998b7Structure)) return false;
return (this == (ST_bc70ab3695876bb4315a9088f41998b7Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPO_DESCRIPCION_ERROR.GetHashCode()
 ^ ssPO_NUMERO_ERROR.GetHashCode()
 ^ ssPO_PDF.GetHashCode()
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


public ST_bc70ab3695876bb4315a9088f41998b7Structure Duplicate() {
ST_bc70ab3695876bb4315a9088f41998b7Structure t;
t.ssPO_DESCRIPCION_ERROR = this.ssPO_DESCRIPCION_ERROR;
t.ssPO_NUMERO_ERROR = this.ssPO_NUMERO_ERROR;
t.ssPO_PDF = this.ssPO_PDF;
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
} else if (head == "po_numero_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_NUMERO_ERROR")) variable.Value = ssPO_NUMERO_ERROR; else variable.Optimized = true;
} else if (head == "po_pdf") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_PDF")) variable.Value = ssPO_PDF; else variable.Optimized = true;
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
if (key == IdPO_NUMERO_ERROR) {
return ssPO_NUMERO_ERROR;
}
if (key == IdPO_PDF) {
return ssPO_PDF;
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
if (attributeKey == IdPO_NUMERO_ERROR.Key.AsGuid) {
return ssPO_NUMERO_ERROR;
}
if (attributeKey == IdPO_PDF.Key.AsGuid) {
return ssPO_PDF;
}
if (attributeKey == IdPO_RESULTADO.Key.AsGuid) {
return ssPO_RESULTADO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPO_DESCRIPCION_ERROR = (string) other.AttributeGet(IdPO_DESCRIPCION_ERROR);
ssPO_NUMERO_ERROR = (int) other.AttributeGet(IdPO_NUMERO_ERROR);
ssPO_PDF = (string) other.AttributeGet(IdPO_PDF);
ssPO_RESULTADO = (string) other.AttributeGet(IdPO_RESULTADO);
}
} // ST_bc70ab3695876bb4315a9088f41998b7Structure
/// <summary>
/// RecordList type <code>ZMXMIMMF_GENERA_PEDIDO_PDFRespList</code> that represents a record list of
///  <code>ZMXMIMMF_GENERA_PEDIDO_PDFResp</code>
/// </summary>
public partial class RL_b93ad71c1d1a4cd9707a150be51faac7 : GenericRecordList<ST_bc70ab3695876bb4315a9088f41998b7Structure>, IEnumerable, IEnumerator {

protected override ST_bc70ab3695876bb4315a9088f41998b7Structure GetElementDefaultValue() {
return new ST_bc70ab3695876bb4315a9088f41998b7Structure();
}

public T[] ToArray<T>(Func<ST_bc70ab3695876bb4315a9088f41998b7Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b93ad71c1d1a4cd9707a150be51faac7 recordList, Func<ST_bc70ab3695876bb4315a9088f41998b7Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b93ad71c1d1a4cd9707a150be51faac7(ST_bc70ab3695876bb4315a9088f41998b7Structure[] array) {
  RL_b93ad71c1d1a4cd9707a150be51faac7 result = new RL_b93ad71c1d1a4cd9707a150be51faac7();
result.InnerFromArray(array);
    return result;
}

public static RL_b93ad71c1d1a4cd9707a150be51faac7 ToList<T>(T[] array, Func <T, ST_bc70ab3695876bb4315a9088f41998b7Structure> converter) {
  RL_b93ad71c1d1a4cd9707a150be51faac7 result = new RL_b93ad71c1d1a4cd9707a150be51faac7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b93ad71c1d1a4cd9707a150be51faac7 FromRestList<T>(RestList<T> restList, Func <T, ST_bc70ab3695876bb4315a9088f41998b7Structure> converter) {
  RL_b93ad71c1d1a4cd9707a150be51faac7 result = new RL_b93ad71c1d1a4cd9707a150be51faac7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b93ad71c1d1a4cd9707a150be51faac7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_bc70ab3695876bb4315a9088f41998b7Structure> NewList() {
return new RL_b93ad71c1d1a4cd9707a150be51faac7();
}


} // RL_b93ad71c1d1a4cd9707a150be51faac7
}

