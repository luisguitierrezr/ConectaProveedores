namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rGYILwXDcEy3oCrWLZ4ahg)
///  <code>RC_6d6e93fa5edbd2aad29e8f15b3f71aeb</code> that represent
/// s <code>ContractFileTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: ContractFileTypeRecord
public partial struct RC_6d6e93fa5edbd2aad29e8f15b3f71aeb : ITypedRecord<RC_6d6e93fa5edbd2aad29e8f15b3f71aeb> {
internal static readonly GlobalObjectKey IdContractFileType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+pNubdteqtLSno8Vs_ca6w");

public EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord ssENContractFileType;


public static implicit operator EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord( RC_6d6e93fa5edbd2aad29e8f15b3f71aeb r) {
return r.ssENContractFileType;
}

public static implicit operator RC_6d6e93fa5edbd2aad29e8f15b3f71aeb (EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord r) {
RC_6d6e93fa5edbd2aad29e8f15b3f71aeb res = new RC_6d6e93fa5edbd2aad29e8f15b3f71aeb ();
res.ssENContractFileType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENContractFileType.ChangedAttributes = value;
}
get {
    return ssENContractFileType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_6d6e93fa5edbd2aad29e8f15b3f71aeb() {
OptimizedAttributes = null;
ssENContractFileType = new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENContractFileType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENContractFileType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENContractFileType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENContractFileType.Read( r, ref index);
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
public void ReadIM(RC_6d6e93fa5edbd2aad29e8f15b3f71aeb r) {
this = r;
}


public static bool operator == (RC_6d6e93fa5edbd2aad29e8f15b3f71aeb a, RC_6d6e93fa5edbd2aad29e8f15b3f71aeb b) {
if (a.ssENContractFileType != b.ssENContractFileType) return false;
return true;
}

public static bool operator != (RC_6d6e93fa5edbd2aad29e8f15b3f71aeb a, RC_6d6e93fa5edbd2aad29e8f15b3f71aeb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6d6e93fa5edbd2aad29e8f15b3f71aeb)) return false;
return (this == (RC_6d6e93fa5edbd2aad29e8f15b3f71aeb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENContractFileType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENContractFileType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENContractFileType.InternalRecursiveSave();
}


public RC_6d6e93fa5edbd2aad29e8f15b3f71aeb Duplicate() {
RC_6d6e93fa5edbd2aad29e8f15b3f71aeb t;
t.ssENContractFileType = (EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord)this.ssENContractFileType.Duplicate();
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
if (head == "contractfiletype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractFileType")) variable.Value = ssENContractFileType; else variable.Optimized = true;
variable.SetFieldName("contractfiletype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENContractFileType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENContractFileType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdContractFileType) {
return ssENContractFileType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdContractFileType.Key.AsGuid) {
return ssENContractFileType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENContractFileType.FillFromOther((IRecord) other.AttributeGet(IdContractFileType));
}
} // RC_6d6e93fa5edbd2aad29e8f15b3f71aeb
/// <summary>
/// RecordList type <code>ContractFileTypeRecordList</code> that represents a record list of
///  <code>ContractFileType</code>
/// </summary>
public partial class RL_5620eca7715eea6d845226d058de8f47 : GenericRecordList<RC_6d6e93fa5edbd2aad29e8f15b3f71aeb>, IEnumerable, IEnumerator {

protected override RC_6d6e93fa5edbd2aad29e8f15b3f71aeb GetElementDefaultValue() {
return new RC_6d6e93fa5edbd2aad29e8f15b3f71aeb();
}

public T[] ToArray<T>(Func<RC_6d6e93fa5edbd2aad29e8f15b3f71aeb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5620eca7715eea6d845226d058de8f47 recordList, Func<RC_6d6e93fa5edbd2aad29e8f15b3f71aeb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5620eca7715eea6d845226d058de8f47(RC_6d6e93fa5edbd2aad29e8f15b3f71aeb[] array) {
  RL_5620eca7715eea6d845226d058de8f47 result = new RL_5620eca7715eea6d845226d058de8f47();
result.InnerFromArray(array);
    return result;
}

public static RL_5620eca7715eea6d845226d058de8f47 ToList<T>(T[] array, Func <T, RC_6d6e93fa5edbd2aad29e8f15b3f71aeb> converter) {
  RL_5620eca7715eea6d845226d058de8f47 result = new RL_5620eca7715eea6d845226d058de8f47();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5620eca7715eea6d845226d058de8f47 FromRestList<T>(RestList<T> restList, Func <T, RC_6d6e93fa5edbd2aad29e8f15b3f71aeb> converter) {
  RL_5620eca7715eea6d845226d058de8f47 result = new RL_5620eca7715eea6d845226d058de8f47();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5620eca7715eea6d845226d058de8f47() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6d6e93fa5edbd2aad29e8f15b3f71aeb> NewList() {
return new RL_5620eca7715eea6d845226d058de8f47();
}


} // RL_5620eca7715eea6d845226d058de8f47
}

