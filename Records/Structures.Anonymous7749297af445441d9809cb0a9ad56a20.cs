namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (eilJd0X0HUSYCcsKmtVqIA)
///  <code>RC_8bfcc1d381d104953fbf01fd54a56e45</code> that represents <code>SeriesTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SeriesTypeRecord
public partial struct RC_8bfcc1d381d104953fbf01fd54a56e45 : ITypedRecord<RC_8bfcc1d381d104953fbf01fd54a56e45> {
internal static readonly GlobalObjectKey IdSeriesType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*08H8i9GBlQQ_vwH9VKVuRQ");

public EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord ssENSeriesType;


public static implicit operator EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord( RC_8bfcc1d381d104953fbf01fd54a56e45 r) {
return r.ssENSeriesType;
}

public static implicit operator RC_8bfcc1d381d104953fbf01fd54a56e45 (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord r) {
RC_8bfcc1d381d104953fbf01fd54a56e45 res = new RC_8bfcc1d381d104953fbf01fd54a56e45 ();
res.ssENSeriesType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSeriesType.ChangedAttributes = value;
}
get {
    return ssENSeriesType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_8bfcc1d381d104953fbf01fd54a56e45() {
OptimizedAttributes = null;
ssENSeriesType = new EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSeriesType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSeriesType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSeriesType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSeriesType.Read( r, ref index);
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
public void ReadIM(RC_8bfcc1d381d104953fbf01fd54a56e45 r) {
this = r;
}


public static bool operator == (RC_8bfcc1d381d104953fbf01fd54a56e45 a, RC_8bfcc1d381d104953fbf01fd54a56e45 b) {
if (a.ssENSeriesType != b.ssENSeriesType) return false;
return true;
}

public static bool operator != (RC_8bfcc1d381d104953fbf01fd54a56e45 a, RC_8bfcc1d381d104953fbf01fd54a56e45 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8bfcc1d381d104953fbf01fd54a56e45)) return false;
return (this == (RC_8bfcc1d381d104953fbf01fd54a56e45)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSeriesType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSeriesType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSeriesType.InternalRecursiveSave();
}


public RC_8bfcc1d381d104953fbf01fd54a56e45 Duplicate() {
RC_8bfcc1d381d104953fbf01fd54a56e45 t;
t.ssENSeriesType = (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord)this.ssENSeriesType.Duplicate();
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
if (head == "seriestype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SeriesType")) variable.Value = ssENSeriesType; else variable.Optimized = true;
variable.SetFieldName("seriestype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSeriesType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSeriesType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSeriesType) {
return ssENSeriesType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSeriesType.Key.AsGuid) {
return ssENSeriesType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSeriesType.FillFromOther((IRecord) other.AttributeGet(IdSeriesType));
}
} // RC_8bfcc1d381d104953fbf01fd54a56e45
/// <summary>
/// RecordList type <code>SeriesTypeRecordList</code> that represents a record list of
///  <code>SeriesType</code>
/// </summary>
public partial class RL_5183695f922445931daf051508280c46 : GenericRecordList<RC_8bfcc1d381d104953fbf01fd54a56e45>, IEnumerable, IEnumerator {

protected override RC_8bfcc1d381d104953fbf01fd54a56e45 GetElementDefaultValue() {
return new RC_8bfcc1d381d104953fbf01fd54a56e45();
}

public T[] ToArray<T>(Func<RC_8bfcc1d381d104953fbf01fd54a56e45, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5183695f922445931daf051508280c46 recordList, Func<RC_8bfcc1d381d104953fbf01fd54a56e45, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5183695f922445931daf051508280c46(RC_8bfcc1d381d104953fbf01fd54a56e45[] array) {
  RL_5183695f922445931daf051508280c46 result = new RL_5183695f922445931daf051508280c46();
result.InnerFromArray(array);
    return result;
}

public static RL_5183695f922445931daf051508280c46 ToList<T>(T[] array, Func <T, RC_8bfcc1d381d104953fbf01fd54a56e45> converter) {
  RL_5183695f922445931daf051508280c46 result = new RL_5183695f922445931daf051508280c46();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5183695f922445931daf051508280c46 FromRestList<T>(RestList<T> restList, Func <T, RC_8bfcc1d381d104953fbf01fd54a56e45> converter) {
  RL_5183695f922445931daf051508280c46 result = new RL_5183695f922445931daf051508280c46();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5183695f922445931daf051508280c46() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8bfcc1d381d104953fbf01fd54a56e45> NewList() {
return new RL_5183695f922445931daf051508280c46();
}


} // RL_5183695f922445931daf051508280c46
}

