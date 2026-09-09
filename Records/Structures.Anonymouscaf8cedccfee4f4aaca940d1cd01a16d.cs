namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3M74yu7PSk+sqUDRzQGhbQ)
///  <code>RC_df27c8a3fd58b3a0547b138755710019</code> that represents <code>OptionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OptionRecord
public partial struct RC_df27c8a3fd58b3a0547b138755710019 : ITypedRecord<RC_df27c8a3fd58b3a0547b138755710019> {
internal static readonly GlobalObjectKey IdOption = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o8gn31j9oLNUexOHVXEAGQ");

public string ssOption;


public BitArray OptimizedAttributes;

public RC_df27c8a3fd58b3a0547b138755710019() {
OptimizedAttributes = null;
ssOption = "";
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
ssOption = r.ReadText(index++, "OptionRecord.Option", "");
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
public void ReadIM(RC_df27c8a3fd58b3a0547b138755710019 r) {
this = r;
}


public static bool operator == (RC_df27c8a3fd58b3a0547b138755710019 a, RC_df27c8a3fd58b3a0547b138755710019 b) {
if (a.ssOption != b.ssOption) return false;
return true;
}

public static bool operator != (RC_df27c8a3fd58b3a0547b138755710019 a, RC_df27c8a3fd58b3a0547b138755710019 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_df27c8a3fd58b3a0547b138755710019)) return false;
return (this == (RC_df27c8a3fd58b3a0547b138755710019)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOption.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_df27c8a3fd58b3a0547b138755710019 Duplicate() {
RC_df27c8a3fd58b3a0547b138755710019 t;
t.ssOption = this.ssOption;
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
if (head == "option") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Option")) variable.Value = ssOption; else variable.Optimized = true;
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
if (key == IdOption) {
return ssOption;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOption.Key.AsGuid) {
return ssOption;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOption = (string) other.AttributeGet(IdOption);
}
} // RC_df27c8a3fd58b3a0547b138755710019
/// <summary>
/// RecordList type <code>OptionRecordList</code> that represents a record list of <code>Text</code>
/// </summary>
public partial class RL_09892887d9f162affabc738767472ff1 : GenericRecordList<RC_df27c8a3fd58b3a0547b138755710019>, IEnumerable, IEnumerator {

protected override RC_df27c8a3fd58b3a0547b138755710019 GetElementDefaultValue() {
return new RC_df27c8a3fd58b3a0547b138755710019();
}

public T[] ToArray<T>(Func<RC_df27c8a3fd58b3a0547b138755710019, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_09892887d9f162affabc738767472ff1 recordList, Func<RC_df27c8a3fd58b3a0547b138755710019, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_09892887d9f162affabc738767472ff1(RC_df27c8a3fd58b3a0547b138755710019[] array) {
  RL_09892887d9f162affabc738767472ff1 result = new RL_09892887d9f162affabc738767472ff1();
result.InnerFromArray(array);
    return result;
}

public static RL_09892887d9f162affabc738767472ff1 ToList<T>(T[] array, Func <T, RC_df27c8a3fd58b3a0547b138755710019> converter) {
  RL_09892887d9f162affabc738767472ff1 result = new RL_09892887d9f162affabc738767472ff1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_09892887d9f162affabc738767472ff1 FromRestList<T>(RestList<T> restList, Func <T, RC_df27c8a3fd58b3a0547b138755710019> converter) {
  RL_09892887d9f162affabc738767472ff1 result = new RL_09892887d9f162affabc738767472ff1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_09892887d9f162affabc738767472ff1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_df27c8a3fd58b3a0547b138755710019> NewList() {
return new RL_09892887d9f162affabc738767472ff1();
}


} // RL_09892887d9f162affabc738767472ff1
}

