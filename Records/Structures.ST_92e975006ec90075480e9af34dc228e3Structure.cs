namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] EM_SM_CECO_COSMOZ_Response (vt_BAwen4Ear7R6z4hD_sw)
///  <code>ST_92e975006ec90075480e9af34dc228e3Structure</code> that represent
/// s <code>EM_SM_CECO_COSMOZ_Response</code> <p>Description: v</p>
/// </summary>
// Name: EM_SM_CECO_COSMOZ_Response
public partial struct ST_92e975006ec90075480e9af34dc228e3Structure : ITypedRecord<ST_92e975006ec90075480e9af34dc228e3Structure> {
internal static readonly GlobalObjectKey IdEM_SM_CECO_COSMOZ_Response_Struct = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*P57Ng5pgCkexLy1UEm15YA");

public ST_b6cef14925f799164fc3167fe695008bStructure ssEM_SM_CECO_COSMOZ_Response_Struct;


public BitArray OptimizedAttributes;

public ST_92e975006ec90075480e9af34dc228e3Structure() {
OptimizedAttributes = null;
ssEM_SM_CECO_COSMOZ_Response_Struct = new ST_b6cef14925f799164fc3167fe695008bStructure();
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
    ssEM_SM_CECO_COSMOZ_Response_Struct.OptimizedAttributes = value[0];
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
public void ReadIM(ST_92e975006ec90075480e9af34dc228e3Structure r) {
this = r;
}


public static bool operator == (ST_92e975006ec90075480e9af34dc228e3Structure a, ST_92e975006ec90075480e9af34dc228e3Structure b) {
if (a.ssEM_SM_CECO_COSMOZ_Response_Struct != b.ssEM_SM_CECO_COSMOZ_Response_Struct) return false;
return true;
}

public static bool operator != (ST_92e975006ec90075480e9af34dc228e3Structure a, ST_92e975006ec90075480e9af34dc228e3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_92e975006ec90075480e9af34dc228e3Structure)) return false;
return (this == (ST_92e975006ec90075480e9af34dc228e3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEM_SM_CECO_COSMOZ_Response_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssEM_SM_CECO_COSMOZ_Response_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssEM_SM_CECO_COSMOZ_Response_Struct.InternalRecursiveSave();
}


public ST_92e975006ec90075480e9af34dc228e3Structure Duplicate() {
ST_92e975006ec90075480e9af34dc228e3Structure t;
t.ssEM_SM_CECO_COSMOZ_Response_Struct = (ST_b6cef14925f799164fc3167fe695008bStructure)this.ssEM_SM_CECO_COSMOZ_Response_Struct.Duplicate();
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
if (head == "em_sm_ceco_cosmoz_response_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_CECO_COSMOZ_Response_Struct")) variable.Value = ssEM_SM_CECO_COSMOZ_Response_Struct; else variable.Optimized = true;
variable.SetFieldName("em_sm_ceco_cosmoz_response_struct");
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
if (key == IdEM_SM_CECO_COSMOZ_Response_Struct) {
return ssEM_SM_CECO_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_CECO_COSMOZ_Response_Struct.Key.AsGuid) {
return ssEM_SM_CECO_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEM_SM_CECO_COSMOZ_Response_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_CECO_COSMOZ_Response_Struct));
}
} // ST_92e975006ec90075480e9af34dc228e3Structure
/// <summary>
/// RecordList type <code>EM_SM_CECO_COSMOZ_ResponseList</code> that represents a record list of
///  <code>EM_SM_CECO_COSMOZ_Response</code>
/// </summary>
public partial class RL_d4f2b77cafe5a9bfb77625d645956bcd : GenericRecordList<ST_92e975006ec90075480e9af34dc228e3Structure>, IEnumerable, IEnumerator {

protected override ST_92e975006ec90075480e9af34dc228e3Structure GetElementDefaultValue() {
return new ST_92e975006ec90075480e9af34dc228e3Structure();
}

public T[] ToArray<T>(Func<ST_92e975006ec90075480e9af34dc228e3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d4f2b77cafe5a9bfb77625d645956bcd recordList, Func<ST_92e975006ec90075480e9af34dc228e3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d4f2b77cafe5a9bfb77625d645956bcd(ST_92e975006ec90075480e9af34dc228e3Structure[] array) {
  RL_d4f2b77cafe5a9bfb77625d645956bcd result = new RL_d4f2b77cafe5a9bfb77625d645956bcd();
result.InnerFromArray(array);
    return result;
}

public static RL_d4f2b77cafe5a9bfb77625d645956bcd ToList<T>(T[] array, Func <T, ST_92e975006ec90075480e9af34dc228e3Structure> converter) {
  RL_d4f2b77cafe5a9bfb77625d645956bcd result = new RL_d4f2b77cafe5a9bfb77625d645956bcd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d4f2b77cafe5a9bfb77625d645956bcd FromRestList<T>(RestList<T> restList, Func <T, ST_92e975006ec90075480e9af34dc228e3Structure> converter) {
  RL_d4f2b77cafe5a9bfb77625d645956bcd result = new RL_d4f2b77cafe5a9bfb77625d645956bcd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d4f2b77cafe5a9bfb77625d645956bcd() : base() {
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
protected override OSList<ST_92e975006ec90075480e9af34dc228e3Structure> NewList() {
return new RL_d4f2b77cafe5a9bfb77625d645956bcd();
}


} // RL_d4f2b77cafe5a9bfb77625d645956bcd
}

