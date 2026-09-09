namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (l4oSqIJWeUSGnBxiAxNp7A)
///  <code>RC_4cea68d4a46fbd7372d4f181e98bfcdb</code> that represents <code>CustomSettingsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CustomSettingsRecord
public partial struct RC_4cea68d4a46fbd7372d4f181e98bfcdb : ITypedRecord<RC_4cea68d4a46fbd7372d4f181e98bfcdb> {
internal static readonly GlobalObjectKey IdCustomSettings = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1GjqTG+kc71y1PGB6Yv82w");

public EN_2598b425876f6271c300c0879185e230EntityRecord ssENCustomSettings;


public static implicit operator EN_2598b425876f6271c300c0879185e230EntityRecord( RC_4cea68d4a46fbd7372d4f181e98bfcdb r) {
return r.ssENCustomSettings;
}

public static implicit operator RC_4cea68d4a46fbd7372d4f181e98bfcdb (EN_2598b425876f6271c300c0879185e230EntityRecord r) {
RC_4cea68d4a46fbd7372d4f181e98bfcdb res = new RC_4cea68d4a46fbd7372d4f181e98bfcdb ();
res.ssENCustomSettings = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCustomSettings.ChangedAttributes = value;
}
get {
    return ssENCustomSettings.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_4cea68d4a46fbd7372d4f181e98bfcdb() {
OptimizedAttributes = null;
ssENCustomSettings = new EN_2598b425876f6271c300c0879185e230EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCustomSettings.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCustomSettings.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCustomSettings.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCustomSettings.Read( r, ref index);
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
public void ReadIM(RC_4cea68d4a46fbd7372d4f181e98bfcdb r) {
this = r;
}


public static bool operator == (RC_4cea68d4a46fbd7372d4f181e98bfcdb a, RC_4cea68d4a46fbd7372d4f181e98bfcdb b) {
if (a.ssENCustomSettings != b.ssENCustomSettings) return false;
return true;
}

public static bool operator != (RC_4cea68d4a46fbd7372d4f181e98bfcdb a, RC_4cea68d4a46fbd7372d4f181e98bfcdb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4cea68d4a46fbd7372d4f181e98bfcdb)) return false;
return (this == (RC_4cea68d4a46fbd7372d4f181e98bfcdb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCustomSettings.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCustomSettings.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCustomSettings.InternalRecursiveSave();
}


public RC_4cea68d4a46fbd7372d4f181e98bfcdb Duplicate() {
RC_4cea68d4a46fbd7372d4f181e98bfcdb t;
t.ssENCustomSettings = (EN_2598b425876f6271c300c0879185e230EntityRecord)this.ssENCustomSettings.Duplicate();
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
if (head == "customsettings") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CustomSettings")) variable.Value = ssENCustomSettings; else variable.Optimized = true;
variable.SetFieldName("customsettings");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCustomSettings.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCustomSettings.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCustomSettings) {
return ssENCustomSettings;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCustomSettings.Key.AsGuid) {
return ssENCustomSettings;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCustomSettings.FillFromOther((IRecord) other.AttributeGet(IdCustomSettings));
}
} // RC_4cea68d4a46fbd7372d4f181e98bfcdb
/// <summary>
/// RecordList type <code>CustomSettingsRecordList</code> that represents a record list of
///  <code>CustomSettings</code>
/// </summary>
public partial class RL_ac40b448986822757e26e354e2bc222a : GenericRecordList<RC_4cea68d4a46fbd7372d4f181e98bfcdb>, IEnumerable, IEnumerator {

protected override RC_4cea68d4a46fbd7372d4f181e98bfcdb GetElementDefaultValue() {
return new RC_4cea68d4a46fbd7372d4f181e98bfcdb();
}

public T[] ToArray<T>(Func<RC_4cea68d4a46fbd7372d4f181e98bfcdb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ac40b448986822757e26e354e2bc222a recordList, Func<RC_4cea68d4a46fbd7372d4f181e98bfcdb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ac40b448986822757e26e354e2bc222a(RC_4cea68d4a46fbd7372d4f181e98bfcdb[] array) {
  RL_ac40b448986822757e26e354e2bc222a result = new RL_ac40b448986822757e26e354e2bc222a();
result.InnerFromArray(array);
    return result;
}

public static RL_ac40b448986822757e26e354e2bc222a ToList<T>(T[] array, Func <T, RC_4cea68d4a46fbd7372d4f181e98bfcdb> converter) {
  RL_ac40b448986822757e26e354e2bc222a result = new RL_ac40b448986822757e26e354e2bc222a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ac40b448986822757e26e354e2bc222a FromRestList<T>(RestList<T> restList, Func <T, RC_4cea68d4a46fbd7372d4f181e98bfcdb> converter) {
  RL_ac40b448986822757e26e354e2bc222a result = new RL_ac40b448986822757e26e354e2bc222a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ac40b448986822757e26e354e2bc222a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_4cea68d4a46fbd7372d4f181e98bfcdb> NewList() {
return new RL_ac40b448986822757e26e354e2bc222a();
}


} // RL_ac40b448986822757e26e354e2bc222a
}

