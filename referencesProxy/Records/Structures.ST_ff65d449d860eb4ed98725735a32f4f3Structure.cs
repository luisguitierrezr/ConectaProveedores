namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] EM_COSMOZ_Response (+3lcoH7YOkKHUkFAOnr_+g)
///  <code>ST_ff65d449d860eb4ed98725735a32f4f3Structure</code> that represent
/// s <code>EM_COSMOZ_Response</code> <p>Description: EM_COSMOZ_Response</p>
/// </summary>
// Name: EM_COSMOZ_Response
public partial struct ST_ff65d449d860eb4ed98725735a32f4f3Structure : ITypedRecord<ST_ff65d449d860eb4ed98725735a32f4f3Structure> {
internal static readonly GlobalObjectKey IdEM_COSMOZ_Response_Struct = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*y8YMNcxyqUCNW+PRH5_zcg");

public ST_5bf89f3eec4235b40802e9da4fd3e4afStructure ssEM_COSMOZ_Response_Struct;


public BitArray OptimizedAttributes;

public ST_ff65d449d860eb4ed98725735a32f4f3Structure() {
OptimizedAttributes = null;
ssEM_COSMOZ_Response_Struct = new ST_5bf89f3eec4235b40802e9da4fd3e4afStructure();
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
    ssEM_COSMOZ_Response_Struct.OptimizedAttributes = value[0];
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
public void ReadIM(ST_ff65d449d860eb4ed98725735a32f4f3Structure r) {
this = r;
}


public static bool operator == (ST_ff65d449d860eb4ed98725735a32f4f3Structure a, ST_ff65d449d860eb4ed98725735a32f4f3Structure b) {
if (a.ssEM_COSMOZ_Response_Struct != b.ssEM_COSMOZ_Response_Struct) return false;
return true;
}

public static bool operator != (ST_ff65d449d860eb4ed98725735a32f4f3Structure a, ST_ff65d449d860eb4ed98725735a32f4f3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ff65d449d860eb4ed98725735a32f4f3Structure)) return false;
return (this == (ST_ff65d449d860eb4ed98725735a32f4f3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEM_COSMOZ_Response_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssEM_COSMOZ_Response_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssEM_COSMOZ_Response_Struct.InternalRecursiveSave();
}


public ST_ff65d449d860eb4ed98725735a32f4f3Structure Duplicate() {
ST_ff65d449d860eb4ed98725735a32f4f3Structure t;
t.ssEM_COSMOZ_Response_Struct = (ST_5bf89f3eec4235b40802e9da4fd3e4afStructure)this.ssEM_COSMOZ_Response_Struct.Duplicate();
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
if (head == "em_cosmoz_response_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_COSMOZ_Response_Struct")) variable.Value = ssEM_COSMOZ_Response_Struct; else variable.Optimized = true;
variable.SetFieldName("em_cosmoz_response_struct");
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
if (key == IdEM_COSMOZ_Response_Struct) {
return ssEM_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_COSMOZ_Response_Struct.Key.AsGuid) {
return ssEM_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEM_COSMOZ_Response_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_COSMOZ_Response_Struct));
}
} // ST_ff65d449d860eb4ed98725735a32f4f3Structure
/// <summary>
/// RecordList type <code>EM_COSMOZ_ResponseList</code> that represents a record list of
///  <code>EM_COSMOZ_Response</code>
/// </summary>
public partial class RL_812768930465aa9eb09ddfdf5b55179f : GenericRecordList<ST_ff65d449d860eb4ed98725735a32f4f3Structure>, IEnumerable, IEnumerator {

protected override ST_ff65d449d860eb4ed98725735a32f4f3Structure GetElementDefaultValue() {
return new ST_ff65d449d860eb4ed98725735a32f4f3Structure();
}

public T[] ToArray<T>(Func<ST_ff65d449d860eb4ed98725735a32f4f3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_812768930465aa9eb09ddfdf5b55179f recordList, Func<ST_ff65d449d860eb4ed98725735a32f4f3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_812768930465aa9eb09ddfdf5b55179f(ST_ff65d449d860eb4ed98725735a32f4f3Structure[] array) {
  RL_812768930465aa9eb09ddfdf5b55179f result = new RL_812768930465aa9eb09ddfdf5b55179f();
result.InnerFromArray(array);
    return result;
}

public static RL_812768930465aa9eb09ddfdf5b55179f ToList<T>(T[] array, Func <T, ST_ff65d449d860eb4ed98725735a32f4f3Structure> converter) {
  RL_812768930465aa9eb09ddfdf5b55179f result = new RL_812768930465aa9eb09ddfdf5b55179f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_812768930465aa9eb09ddfdf5b55179f FromRestList<T>(RestList<T> restList, Func <T, ST_ff65d449d860eb4ed98725735a32f4f3Structure> converter) {
  RL_812768930465aa9eb09ddfdf5b55179f result = new RL_812768930465aa9eb09ddfdf5b55179f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_812768930465aa9eb09ddfdf5b55179f() : base() {
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
protected override OSList<ST_ff65d449d860eb4ed98725735a32f4f3Structure> NewList() {
return new RL_812768930465aa9eb09ddfdf5b55179f();
}


} // RL_812768930465aa9eb09ddfdf5b55179f
}

