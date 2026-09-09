namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (HK52qdUP7Um_xTxZrOXtDA)
///  <code>RC_de9ad81c85170f7fe0ed05c43c7a0f93</code> that represent
/// s <code>EM_COSMOZ_ResponseRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_COSMOZ_ResponseRecord
public partial struct RC_de9ad81c85170f7fe0ed05c43c7a0f93 : ITypedRecord<RC_de9ad81c85170f7fe0ed05c43c7a0f93> {
internal static readonly GlobalObjectKey IdEM_COSMOZ_Response = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HNia3heFfw_g7QXEPHoPkw");

public ST_ff65d449d860eb4ed98725735a32f4f3Structure ssSTEM_COSMOZ_Response;


public static implicit operator ST_ff65d449d860eb4ed98725735a32f4f3Structure( RC_de9ad81c85170f7fe0ed05c43c7a0f93 r) {
return r.ssSTEM_COSMOZ_Response;
}

public static implicit operator RC_de9ad81c85170f7fe0ed05c43c7a0f93 (ST_ff65d449d860eb4ed98725735a32f4f3Structure r) {
RC_de9ad81c85170f7fe0ed05c43c7a0f93 res = new RC_de9ad81c85170f7fe0ed05c43c7a0f93 ();
res.ssSTEM_COSMOZ_Response = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_de9ad81c85170f7fe0ed05c43c7a0f93() {
OptimizedAttributes = null;
ssSTEM_COSMOZ_Response = new ST_ff65d449d860eb4ed98725735a32f4f3Structure();
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
    ssSTEM_COSMOZ_Response.OptimizedAttributes = value[0];
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
ssSTEM_COSMOZ_Response.Read( r, ref index);
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
public void ReadIM(RC_de9ad81c85170f7fe0ed05c43c7a0f93 r) {
this = r;
}


public static bool operator == (RC_de9ad81c85170f7fe0ed05c43c7a0f93 a, RC_de9ad81c85170f7fe0ed05c43c7a0f93 b) {
if (a.ssSTEM_COSMOZ_Response != b.ssSTEM_COSMOZ_Response) return false;
return true;
}

public static bool operator != (RC_de9ad81c85170f7fe0ed05c43c7a0f93 a, RC_de9ad81c85170f7fe0ed05c43c7a0f93 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_de9ad81c85170f7fe0ed05c43c7a0f93)) return false;
return (this == (RC_de9ad81c85170f7fe0ed05c43c7a0f93)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_COSMOZ_Response.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_COSMOZ_Response.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_COSMOZ_Response.InternalRecursiveSave();
}


public RC_de9ad81c85170f7fe0ed05c43c7a0f93 Duplicate() {
RC_de9ad81c85170f7fe0ed05c43c7a0f93 t;
t.ssSTEM_COSMOZ_Response = (ST_ff65d449d860eb4ed98725735a32f4f3Structure)this.ssSTEM_COSMOZ_Response.Duplicate();
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
if (head == "em_cosmoz_response") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_COSMOZ_Response")) variable.Value = ssSTEM_COSMOZ_Response; else variable.Optimized = true;
variable.SetFieldName("em_cosmoz_response");
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
if (key == IdEM_COSMOZ_Response) {
return ssSTEM_COSMOZ_Response;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_COSMOZ_Response.Key.AsGuid) {
return ssSTEM_COSMOZ_Response;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_COSMOZ_Response.FillFromOther((IRecord) other.AttributeGet(IdEM_COSMOZ_Response));
}
} // RC_de9ad81c85170f7fe0ed05c43c7a0f93
/// <summary>
/// RecordList type <code>EM_COSMOZ_ResponseRecordList</code> that represents a record list of
///  <code>EM_COSMOZ_Response</code>
/// </summary>
public partial class RL_7076aa7039084abad53fa99bc6fdae1e : GenericRecordList<RC_de9ad81c85170f7fe0ed05c43c7a0f93>, IEnumerable, IEnumerator {

protected override RC_de9ad81c85170f7fe0ed05c43c7a0f93 GetElementDefaultValue() {
return new RC_de9ad81c85170f7fe0ed05c43c7a0f93();
}

public T[] ToArray<T>(Func<RC_de9ad81c85170f7fe0ed05c43c7a0f93, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7076aa7039084abad53fa99bc6fdae1e recordList, Func<RC_de9ad81c85170f7fe0ed05c43c7a0f93, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7076aa7039084abad53fa99bc6fdae1e(RC_de9ad81c85170f7fe0ed05c43c7a0f93[] array) {
  RL_7076aa7039084abad53fa99bc6fdae1e result = new RL_7076aa7039084abad53fa99bc6fdae1e();
result.InnerFromArray(array);
    return result;
}

public static RL_7076aa7039084abad53fa99bc6fdae1e ToList<T>(T[] array, Func <T, RC_de9ad81c85170f7fe0ed05c43c7a0f93> converter) {
  RL_7076aa7039084abad53fa99bc6fdae1e result = new RL_7076aa7039084abad53fa99bc6fdae1e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7076aa7039084abad53fa99bc6fdae1e FromRestList<T>(RestList<T> restList, Func <T, RC_de9ad81c85170f7fe0ed05c43c7a0f93> converter) {
  RL_7076aa7039084abad53fa99bc6fdae1e result = new RL_7076aa7039084abad53fa99bc6fdae1e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7076aa7039084abad53fa99bc6fdae1e() : base() {
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
protected override OSList<RC_de9ad81c85170f7fe0ed05c43c7a0f93> NewList() {
return new RL_7076aa7039084abad53fa99bc6fdae1e();
}


} // RL_7076aa7039084abad53fa99bc6fdae1e
}

