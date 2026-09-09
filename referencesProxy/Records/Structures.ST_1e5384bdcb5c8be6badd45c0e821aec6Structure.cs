namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] PostValidacfdiprovRequestWrapper (PkYMPjU5mECfF+P5xVqU8Q)
///  <code>ST_1e5384bdcb5c8be6badd45c0e821aec6Structure</code> that represent
/// s <code>PostValidacfdiprovRequestWrapper</code> <p>Description: </p>
/// </summary>
// Name: PostValidacfdiprovRequestWrapper
public partial struct ST_1e5384bdcb5c8be6badd45c0e821aec6Structure : ITypedRecord<ST_1e5384bdcb5c8be6badd45c0e821aec6Structure> {
internal static readonly GlobalObjectKey IdSociedad = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*ZEHFHasWkEunvev+F+dwYQ");
internal static readonly GlobalObjectKey IdCfdFile = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*AvJxFIkQZ0S943s6GRiEaw");

public string ssSociedad;

public string ssCfdFile;


public BitArray OptimizedAttributes;

public ST_1e5384bdcb5c8be6badd45c0e821aec6Structure() {
OptimizedAttributes = null;
ssSociedad = "";
ssCfdFile = "";
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
ssSociedad = r.ReadText(index++, "PostValidacfdiprovRequestWrapper.Sociedad", "");
ssCfdFile = r.ReadText(index++, "PostValidacfdiprovRequestWrapper.CfdFile", "");
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
public void ReadIM(ST_1e5384bdcb5c8be6badd45c0e821aec6Structure r) {
this = r;
}


public static bool operator == (ST_1e5384bdcb5c8be6badd45c0e821aec6Structure a, ST_1e5384bdcb5c8be6badd45c0e821aec6Structure b) {
if (a.ssSociedad != b.ssSociedad) return false;
if (a.ssCfdFile != b.ssCfdFile) return false;
return true;
}

public static bool operator != (ST_1e5384bdcb5c8be6badd45c0e821aec6Structure a, ST_1e5384bdcb5c8be6badd45c0e821aec6Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1e5384bdcb5c8be6badd45c0e821aec6Structure)) return false;
return (this == (ST_1e5384bdcb5c8be6badd45c0e821aec6Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSociedad.GetHashCode()
 ^ ssCfdFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1e5384bdcb5c8be6badd45c0e821aec6Structure Duplicate() {
ST_1e5384bdcb5c8be6badd45c0e821aec6Structure t;
t.ssSociedad = this.ssSociedad;
t.ssCfdFile = this.ssCfdFile;
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
if (head == "sociedad") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sociedad")) variable.Value = ssSociedad; else variable.Optimized = true;
} else if (head == "cfdfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CfdFile")) variable.Value = ssCfdFile; else variable.Optimized = true;
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
if (key == IdSociedad) {
return ssSociedad;
}
if (key == IdCfdFile) {
return ssCfdFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSociedad.Key.AsGuid) {
return ssSociedad;
}
if (attributeKey == IdCfdFile.Key.AsGuid) {
return ssCfdFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSociedad = (string) other.AttributeGet(IdSociedad);
ssCfdFile = (string) other.AttributeGet(IdCfdFile);
}
} // ST_1e5384bdcb5c8be6badd45c0e821aec6Structure
/// <summary>
/// RecordList type <code>PostValidacfdiprovRequestWrapperList</code> that represents a record list of
///  <code>PostValidacfdiprovRequestWrapper</code>
/// </summary>
public partial class RL_c6a8b3c3f81c9fd64281639dff07d094 : GenericRecordList<ST_1e5384bdcb5c8be6badd45c0e821aec6Structure>, IEnumerable, IEnumerator {

protected override ST_1e5384bdcb5c8be6badd45c0e821aec6Structure GetElementDefaultValue() {
return new ST_1e5384bdcb5c8be6badd45c0e821aec6Structure();
}

public T[] ToArray<T>(Func<ST_1e5384bdcb5c8be6badd45c0e821aec6Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c6a8b3c3f81c9fd64281639dff07d094 recordList, Func<ST_1e5384bdcb5c8be6badd45c0e821aec6Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c6a8b3c3f81c9fd64281639dff07d094(ST_1e5384bdcb5c8be6badd45c0e821aec6Structure[] array) {
  RL_c6a8b3c3f81c9fd64281639dff07d094 result = new RL_c6a8b3c3f81c9fd64281639dff07d094();
result.InnerFromArray(array);
    return result;
}

public static RL_c6a8b3c3f81c9fd64281639dff07d094 ToList<T>(T[] array, Func <T, ST_1e5384bdcb5c8be6badd45c0e821aec6Structure> converter) {
  RL_c6a8b3c3f81c9fd64281639dff07d094 result = new RL_c6a8b3c3f81c9fd64281639dff07d094();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c6a8b3c3f81c9fd64281639dff07d094 FromRestList<T>(RestList<T> restList, Func <T, ST_1e5384bdcb5c8be6badd45c0e821aec6Structure> converter) {
  RL_c6a8b3c3f81c9fd64281639dff07d094 result = new RL_c6a8b3c3f81c9fd64281639dff07d094();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c6a8b3c3f81c9fd64281639dff07d094() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1e5384bdcb5c8be6badd45c0e821aec6Structure> NewList() {
return new RL_c6a8b3c3f81c9fd64281639dff07d094();
}


} // RL_c6a8b3c3f81c9fd64281639dff07d094
}

