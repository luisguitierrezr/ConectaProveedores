namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (DUrfunHPyUqWA13xt64KMQ)
///  <code>RC_bd6cd24c0d7565edb91c7512bb29c013</code> that represent
/// s <code>ZMXMIMMF_GENERA_PEDIDO_PDFRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_GENERA_PEDIDO_PDFRespRecord
public partial struct RC_bd6cd24c0d7565edb91c7512bb29c013 : ITypedRecord<RC_bd6cd24c0d7565edb91c7512bb29c013> {
internal static readonly GlobalObjectKey IdZMXMIMMF_GENERA_PEDIDO_PDFResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TNJsvXUN7WW5HHUSuynAEw");

public ST_bc70ab3695876bb4315a9088f41998b7Structure ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp;


public static implicit operator ST_bc70ab3695876bb4315a9088f41998b7Structure( RC_bd6cd24c0d7565edb91c7512bb29c013 r) {
return r.ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp;
}

public static implicit operator RC_bd6cd24c0d7565edb91c7512bb29c013 (ST_bc70ab3695876bb4315a9088f41998b7Structure r) {
RC_bd6cd24c0d7565edb91c7512bb29c013 res = new RC_bd6cd24c0d7565edb91c7512bb29c013 ();
res.ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_bd6cd24c0d7565edb91c7512bb29c013() {
OptimizedAttributes = null;
ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp = new ST_bc70ab3695876bb4315a9088f41998b7Structure();
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
    ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp.Read( r, ref index);
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
public void ReadIM(RC_bd6cd24c0d7565edb91c7512bb29c013 r) {
this = r;
}


public static bool operator == (RC_bd6cd24c0d7565edb91c7512bb29c013 a, RC_bd6cd24c0d7565edb91c7512bb29c013 b) {
if (a.ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp != b.ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp) return false;
return true;
}

public static bool operator != (RC_bd6cd24c0d7565edb91c7512bb29c013 a, RC_bd6cd24c0d7565edb91c7512bb29c013 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bd6cd24c0d7565edb91c7512bb29c013)) return false;
return (this == (RC_bd6cd24c0d7565edb91c7512bb29c013)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp.InternalRecursiveSave();
}


public RC_bd6cd24c0d7565edb91c7512bb29c013 Duplicate() {
RC_bd6cd24c0d7565edb91c7512bb29c013 t;
t.ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp = (ST_bc70ab3695876bb4315a9088f41998b7Structure)this.ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp.Duplicate();
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
if (head == "zmxmimmf_genera_pedido_pdfresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_GENERA_PEDIDO_PDFResp")) variable.Value = ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_genera_pedido_pdfresp");
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
if (key == IdZMXMIMMF_GENERA_PEDIDO_PDFResp) {
return ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_GENERA_PEDIDO_PDFResp.Key.AsGuid) {
return ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_GENERA_PEDIDO_PDFResp));
}
} // RC_bd6cd24c0d7565edb91c7512bb29c013
/// <summary>
/// RecordList type <code>ZMXMIMMF_GENERA_PEDIDO_PDFRespRecordList</code> that represents a record list
///  of <code>ZMXMIMMF_GENERA_PEDIDO_PDFResp</code>
/// </summary>
public partial class RL_cf54b49c92a17dce70b7ac31be4a78a5 : GenericRecordList<RC_bd6cd24c0d7565edb91c7512bb29c013>, IEnumerable, IEnumerator {

protected override RC_bd6cd24c0d7565edb91c7512bb29c013 GetElementDefaultValue() {
return new RC_bd6cd24c0d7565edb91c7512bb29c013();
}

public T[] ToArray<T>(Func<RC_bd6cd24c0d7565edb91c7512bb29c013, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cf54b49c92a17dce70b7ac31be4a78a5 recordList, Func<RC_bd6cd24c0d7565edb91c7512bb29c013, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cf54b49c92a17dce70b7ac31be4a78a5(RC_bd6cd24c0d7565edb91c7512bb29c013[] array) {
  RL_cf54b49c92a17dce70b7ac31be4a78a5 result = new RL_cf54b49c92a17dce70b7ac31be4a78a5();
result.InnerFromArray(array);
    return result;
}

public static RL_cf54b49c92a17dce70b7ac31be4a78a5 ToList<T>(T[] array, Func <T, RC_bd6cd24c0d7565edb91c7512bb29c013> converter) {
  RL_cf54b49c92a17dce70b7ac31be4a78a5 result = new RL_cf54b49c92a17dce70b7ac31be4a78a5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cf54b49c92a17dce70b7ac31be4a78a5 FromRestList<T>(RestList<T> restList, Func <T, RC_bd6cd24c0d7565edb91c7512bb29c013> converter) {
  RL_cf54b49c92a17dce70b7ac31be4a78a5 result = new RL_cf54b49c92a17dce70b7ac31be4a78a5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cf54b49c92a17dce70b7ac31be4a78a5() : base() {
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
protected override OSList<RC_bd6cd24c0d7565edb91c7512bb29c013> NewList() {
return new RL_cf54b49c92a17dce70b7ac31be4a78a5();
}


} // RL_cf54b49c92a17dce70b7ac31be4a78a5
}

