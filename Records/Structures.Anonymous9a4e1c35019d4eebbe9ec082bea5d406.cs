namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (NRxOmp0B606+nsCCvqXUBg)
///  <code>RC_a7394a353dc1b7f636aaced209e66116</code> that represents <code>OrderFileRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderFileRecord
public partial struct RC_a7394a353dc1b7f636aaced209e66116 : ITypedRecord<RC_a7394a353dc1b7f636aaced209e66116> {
internal static readonly GlobalObjectKey IdOrderFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NUo5p8E99rc2qs7SCeZhFg");

public EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFile;


public static implicit operator EN_096339be3ef098b3762e8897e3a1c095EntityRecord( RC_a7394a353dc1b7f636aaced209e66116 r) {
return r.ssENOrderFile;
}

public static implicit operator RC_a7394a353dc1b7f636aaced209e66116 (EN_096339be3ef098b3762e8897e3a1c095EntityRecord r) {
RC_a7394a353dc1b7f636aaced209e66116 res = new RC_a7394a353dc1b7f636aaced209e66116 ();
res.ssENOrderFile = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderFile.ChangedAttributes = value;
}
get {
    return ssENOrderFile.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a7394a353dc1b7f636aaced209e66116() {
OptimizedAttributes = null;
ssENOrderFile = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderFile.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderFile.Read( r, ref index);
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
public void ReadIM(RC_a7394a353dc1b7f636aaced209e66116 r) {
this = r;
}


public static bool operator == (RC_a7394a353dc1b7f636aaced209e66116 a, RC_a7394a353dc1b7f636aaced209e66116 b) {
if (a.ssENOrderFile != b.ssENOrderFile) return false;
return true;
}

public static bool operator != (RC_a7394a353dc1b7f636aaced209e66116 a, RC_a7394a353dc1b7f636aaced209e66116 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a7394a353dc1b7f636aaced209e66116)) return false;
return (this == (RC_a7394a353dc1b7f636aaced209e66116)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderFile.InternalRecursiveSave();
}


public RC_a7394a353dc1b7f636aaced209e66116 Duplicate() {
RC_a7394a353dc1b7f636aaced209e66116 t;
t.ssENOrderFile = (EN_096339be3ef098b3762e8897e3a1c095EntityRecord)this.ssENOrderFile.Duplicate();
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
if (head == "orderfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFile")) variable.Value = ssENOrderFile; else variable.Optimized = true;
variable.SetFieldName("orderfile");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderFile.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderFile.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderFile) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderFile.Key.AsGuid) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderFile.FillFromOther((IRecord) other.AttributeGet(IdOrderFile));
}
} // RC_a7394a353dc1b7f636aaced209e66116
/// <summary>
/// RecordList type <code>OrderFileRecordList</code> that represents a record list of
///  <code>OrderFile</code>
/// </summary>
public partial class RL_1952495fe738735251c431fd1e1fd0f1 : GenericRecordList<RC_a7394a353dc1b7f636aaced209e66116>, IEnumerable, IEnumerator {

protected override RC_a7394a353dc1b7f636aaced209e66116 GetElementDefaultValue() {
return new RC_a7394a353dc1b7f636aaced209e66116();
}

public T[] ToArray<T>(Func<RC_a7394a353dc1b7f636aaced209e66116, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1952495fe738735251c431fd1e1fd0f1 recordList, Func<RC_a7394a353dc1b7f636aaced209e66116, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1952495fe738735251c431fd1e1fd0f1(RC_a7394a353dc1b7f636aaced209e66116[] array) {
  RL_1952495fe738735251c431fd1e1fd0f1 result = new RL_1952495fe738735251c431fd1e1fd0f1();
result.InnerFromArray(array);
    return result;
}

public static RL_1952495fe738735251c431fd1e1fd0f1 ToList<T>(T[] array, Func <T, RC_a7394a353dc1b7f636aaced209e66116> converter) {
  RL_1952495fe738735251c431fd1e1fd0f1 result = new RL_1952495fe738735251c431fd1e1fd0f1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1952495fe738735251c431fd1e1fd0f1 FromRestList<T>(RestList<T> restList, Func <T, RC_a7394a353dc1b7f636aaced209e66116> converter) {
  RL_1952495fe738735251c431fd1e1fd0f1 result = new RL_1952495fe738735251c431fd1e1fd0f1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1952495fe738735251c431fd1e1fd0f1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a7394a353dc1b7f636aaced209e66116> NewList() {
return new RL_1952495fe738735251c431fd1e1fd0f1();
}


} // RL_1952495fe738735251c431fd1e1fd0f1
}

