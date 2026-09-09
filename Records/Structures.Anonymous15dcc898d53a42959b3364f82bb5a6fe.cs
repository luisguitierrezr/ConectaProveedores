namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mMjcFTrVlUKbM2T4K7Wm_g)
///  <code>RC_1f579c47758735b50f415dd5b367a40b</code> that represents <code>ErrorNumberRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ErrorNumberRecord
public partial struct RC_1f579c47758735b50f415dd5b367a40b : ITypedRecord<RC_1f579c47758735b50f415dd5b367a40b> {
internal static readonly GlobalObjectKey IdError = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Itr+BhSLI9HrhmrQVDmsww");
internal static readonly GlobalObjectKey IdNumber = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S07IXB83IQjEeoU_Kulmxw");

public string ssError;

public string ssNumber;


public BitArray OptimizedAttributes;

public RC_1f579c47758735b50f415dd5b367a40b() {
OptimizedAttributes = null;
ssError = "";
ssNumber = "";
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
ssError = r.ReadText(index++, "ErrorNumberRecord.Error", "");
ssNumber = r.ReadText(index++, "ErrorNumberRecord.Number", "");
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
public void ReadIM(RC_1f579c47758735b50f415dd5b367a40b r) {
this = r;
}


public static bool operator == (RC_1f579c47758735b50f415dd5b367a40b a, RC_1f579c47758735b50f415dd5b367a40b b) {
if (a.ssError != b.ssError) return false;
if (a.ssNumber != b.ssNumber) return false;
return true;
}

public static bool operator != (RC_1f579c47758735b50f415dd5b367a40b a, RC_1f579c47758735b50f415dd5b367a40b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1f579c47758735b50f415dd5b367a40b)) return false;
return (this == (RC_1f579c47758735b50f415dd5b367a40b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssError.GetHashCode()
 ^ ssNumber.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_1f579c47758735b50f415dd5b367a40b Duplicate() {
RC_1f579c47758735b50f415dd5b367a40b t;
t.ssError = this.ssError;
t.ssNumber = this.ssNumber;
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
if (head == "error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Error")) variable.Value = ssError; else variable.Optimized = true;
} else if (head == "number") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Number")) variable.Value = ssNumber; else variable.Optimized = true;
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
if (key == IdError) {
return ssError;
}
if (key == IdNumber) {
return ssNumber;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdError.Key.AsGuid) {
return ssError;
}
if (attributeKey == IdNumber.Key.AsGuid) {
return ssNumber;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssError = (string) other.AttributeGet(IdError);
ssNumber = (string) other.AttributeGet(IdNumber);
}
} // RC_1f579c47758735b50f415dd5b367a40b
/// <summary>
/// RecordList type <code>ErrorNumberRecordList</code> that represents a record list of <code>Text,
///  Text</code>
/// </summary>
public partial class RL_b07a2c599719eeabf4cf87e53c7dda78 : GenericRecordList<RC_1f579c47758735b50f415dd5b367a40b>, IEnumerable, IEnumerator {

protected override RC_1f579c47758735b50f415dd5b367a40b GetElementDefaultValue() {
return new RC_1f579c47758735b50f415dd5b367a40b();
}

public T[] ToArray<T>(Func<RC_1f579c47758735b50f415dd5b367a40b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b07a2c599719eeabf4cf87e53c7dda78 recordList, Func<RC_1f579c47758735b50f415dd5b367a40b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b07a2c599719eeabf4cf87e53c7dda78(RC_1f579c47758735b50f415dd5b367a40b[] array) {
  RL_b07a2c599719eeabf4cf87e53c7dda78 result = new RL_b07a2c599719eeabf4cf87e53c7dda78();
result.InnerFromArray(array);
    return result;
}

public static RL_b07a2c599719eeabf4cf87e53c7dda78 ToList<T>(T[] array, Func <T, RC_1f579c47758735b50f415dd5b367a40b> converter) {
  RL_b07a2c599719eeabf4cf87e53c7dda78 result = new RL_b07a2c599719eeabf4cf87e53c7dda78();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b07a2c599719eeabf4cf87e53c7dda78 FromRestList<T>(RestList<T> restList, Func <T, RC_1f579c47758735b50f415dd5b367a40b> converter) {
  RL_b07a2c599719eeabf4cf87e53c7dda78 result = new RL_b07a2c599719eeabf4cf87e53c7dda78();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b07a2c599719eeabf4cf87e53c7dda78() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1f579c47758735b50f415dd5b367a40b> NewList() {
return new RL_b07a2c599719eeabf4cf87e53c7dda78();
}


} // RL_b07a2c599719eeabf4cf87e53c7dda78
}

