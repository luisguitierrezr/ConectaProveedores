namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_EM_SM_RM_COSMOZReq (aNxYbqiqEU+2_Id6SsylaA)
///  <code>ST_e629b825a45e94758f239d11120cb772Structure</code> that represent
/// s <code>ZMXMIMMF_EM_SM_RM_COSMOZReq</code> <p>Description: ZMXMIMMF_EM_SM_RM_COSMOZReq</p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_RM_COSMOZReq
public partial struct ST_e629b825a45e94758f239d11120cb772Structure : ITypedRecord<ST_e629b825a45e94758f239d11120cb772Structure> {
internal static readonly GlobalObjectKey IdPI_HEADER = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*eHTHJEyib0C1aX7jMqFVfQ");
internal static readonly GlobalObjectKey IdPI_ITEM_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*AeJ3R8YPo0G5a1jlFyk_cQ");
internal static readonly GlobalObjectKey IdPI_ITEM_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*LAr5p6r4pk6sWdwsJ2dj7w");

public ST_976925bffb49d1800d61d6274bd325dfStructure ssPI_HEADER;

public RL_7467e78eb931d55f4ebaca0d0fac8a6d ssPI_ITEM_EM;

public RL_6c5e26ef7403cc17d38ef0323d406754 ssPI_ITEM_SM;


public BitArray OptimizedAttributes;

public ST_e629b825a45e94758f239d11120cb772Structure() {
OptimizedAttributes = null;
ssPI_HEADER = new ST_976925bffb49d1800d61d6274bd325dfStructure();
ssPI_ITEM_EM = new RL_7467e78eb931d55f4ebaca0d0fac8a6d();
ssPI_ITEM_SM = new RL_6c5e26ef7403cc17d38ef0323d406754();
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
    ssPI_HEADER.OptimizedAttributes = value[0];
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
public void ReadIM(ST_e629b825a45e94758f239d11120cb772Structure r) {
this = r;
}


public static bool operator == (ST_e629b825a45e94758f239d11120cb772Structure a, ST_e629b825a45e94758f239d11120cb772Structure b) {
if (a.ssPI_HEADER != b.ssPI_HEADER) return false;
if (a.ssPI_ITEM_EM != b.ssPI_ITEM_EM) return false;
if (a.ssPI_ITEM_SM != b.ssPI_ITEM_SM) return false;
return true;
}

public static bool operator != (ST_e629b825a45e94758f239d11120cb772Structure a, ST_e629b825a45e94758f239d11120cb772Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e629b825a45e94758f239d11120cb772Structure)) return false;
return (this == (ST_e629b825a45e94758f239d11120cb772Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_HEADER.GetHashCode()
 ^ ssPI_ITEM_EM.GetHashCode()
 ^ ssPI_ITEM_SM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssPI_HEADER.RecursiveReset();
ssPI_ITEM_EM.RecursiveReset();
ssPI_ITEM_SM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssPI_HEADER.InternalRecursiveSave();
ssPI_ITEM_EM.InternalRecursiveSave();
ssPI_ITEM_SM.InternalRecursiveSave();
}


public ST_e629b825a45e94758f239d11120cb772Structure Duplicate() {
ST_e629b825a45e94758f239d11120cb772Structure t;
t.ssPI_HEADER = (ST_976925bffb49d1800d61d6274bd325dfStructure)this.ssPI_HEADER.Duplicate();
t.ssPI_ITEM_EM = (RL_7467e78eb931d55f4ebaca0d0fac8a6d)this.ssPI_ITEM_EM.Duplicate();
t.ssPI_ITEM_SM = (RL_6c5e26ef7403cc17d38ef0323d406754)this.ssPI_ITEM_SM.Duplicate();
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
if (head == "pi_header") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER")) variable.Value = ssPI_HEADER; else variable.Optimized = true;
variable.SetFieldName("pi_header");
} else if (head == "pi_item_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM")) variable.Value = ssPI_ITEM_EM; else variable.Optimized = true;
variable.SetFieldName("pi_item_em");
} else if (head == "pi_item_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_SM")) variable.Value = ssPI_ITEM_SM; else variable.Optimized = true;
variable.SetFieldName("pi_item_sm");
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
if (key == IdPI_HEADER) {
return ssPI_HEADER;
}
if (key == IdPI_ITEM_EM) {
return ssPI_ITEM_EM;
}
if (key == IdPI_ITEM_SM) {
return ssPI_ITEM_SM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER.Key.AsGuid) {
return ssPI_HEADER;
}
if (attributeKey == IdPI_ITEM_EM.Key.AsGuid) {
return ssPI_ITEM_EM;
}
if (attributeKey == IdPI_ITEM_SM.Key.AsGuid) {
return ssPI_ITEM_SM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_HEADER.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER));
ssPI_ITEM_EM = new RL_7467e78eb931d55f4ebaca0d0fac8a6d();
ssPI_ITEM_EM.FillFromOther((IOSList) other.AttributeGet(IdPI_ITEM_EM));
ssPI_ITEM_SM = new RL_6c5e26ef7403cc17d38ef0323d406754();
ssPI_ITEM_SM.FillFromOther((IOSList) other.AttributeGet(IdPI_ITEM_SM));
}
} // ST_e629b825a45e94758f239d11120cb772Structure
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_RM_COSMOZReqList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_SM_RM_COSMOZReq</code>
/// </summary>
public partial class RL_b135fc7888fa568ee02771c08fd4a784 : GenericRecordList<ST_e629b825a45e94758f239d11120cb772Structure>, IEnumerable, IEnumerator {

protected override ST_e629b825a45e94758f239d11120cb772Structure GetElementDefaultValue() {
return new ST_e629b825a45e94758f239d11120cb772Structure();
}

public T[] ToArray<T>(Func<ST_e629b825a45e94758f239d11120cb772Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b135fc7888fa568ee02771c08fd4a784 recordList, Func<ST_e629b825a45e94758f239d11120cb772Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b135fc7888fa568ee02771c08fd4a784(ST_e629b825a45e94758f239d11120cb772Structure[] array) {
  RL_b135fc7888fa568ee02771c08fd4a784 result = new RL_b135fc7888fa568ee02771c08fd4a784();
result.InnerFromArray(array);
    return result;
}

public static RL_b135fc7888fa568ee02771c08fd4a784 ToList<T>(T[] array, Func <T, ST_e629b825a45e94758f239d11120cb772Structure> converter) {
  RL_b135fc7888fa568ee02771c08fd4a784 result = new RL_b135fc7888fa568ee02771c08fd4a784();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b135fc7888fa568ee02771c08fd4a784 FromRestList<T>(RestList<T> restList, Func <T, ST_e629b825a45e94758f239d11120cb772Structure> converter) {
  RL_b135fc7888fa568ee02771c08fd4a784 result = new RL_b135fc7888fa568ee02771c08fd4a784();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b135fc7888fa568ee02771c08fd4a784() : base() {
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
protected override OSList<ST_e629b825a45e94758f239d11120cb772Structure> NewList() {
return new RL_b135fc7888fa568ee02771c08fd4a784();
}


} // RL_b135fc7888fa568ee02771c08fd4a784
}

