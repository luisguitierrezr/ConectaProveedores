namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (9D0A0rn2mEuuF+3Pl5gkJQ)
///  <code>RC_f2c609d858f8411e75fbedee60c5dddf</code> that represents <code>FrequencyRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FrequencyRecord
public partial struct RC_f2c609d858f8411e75fbedee60c5dddf : ITypedRecord<RC_f2c609d858f8411e75fbedee60c5dddf> {
internal static readonly GlobalObjectKey IdFrequency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2AnG8vhYHkF1++3uYMXd3w");

public EN_a6239c65aa61ed4530d18a92034301bbEntityRecord ssENFrequency;


public static implicit operator EN_a6239c65aa61ed4530d18a92034301bbEntityRecord( RC_f2c609d858f8411e75fbedee60c5dddf r) {
return r.ssENFrequency;
}

public static implicit operator RC_f2c609d858f8411e75fbedee60c5dddf (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord r) {
RC_f2c609d858f8411e75fbedee60c5dddf res = new RC_f2c609d858f8411e75fbedee60c5dddf ();
res.ssENFrequency = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFrequency.ChangedAttributes = value;
}
get {
    return ssENFrequency.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f2c609d858f8411e75fbedee60c5dddf() {
OptimizedAttributes = null;
ssENFrequency = new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFrequency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFrequency.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFrequency.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFrequency.Read( r, ref index);
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
public void ReadIM(RC_f2c609d858f8411e75fbedee60c5dddf r) {
this = r;
}


public static bool operator == (RC_f2c609d858f8411e75fbedee60c5dddf a, RC_f2c609d858f8411e75fbedee60c5dddf b) {
if (a.ssENFrequency != b.ssENFrequency) return false;
return true;
}

public static bool operator != (RC_f2c609d858f8411e75fbedee60c5dddf a, RC_f2c609d858f8411e75fbedee60c5dddf b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f2c609d858f8411e75fbedee60c5dddf)) return false;
return (this == (RC_f2c609d858f8411e75fbedee60c5dddf)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFrequency.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFrequency.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFrequency.InternalRecursiveSave();
}


public RC_f2c609d858f8411e75fbedee60c5dddf Duplicate() {
RC_f2c609d858f8411e75fbedee60c5dddf t;
t.ssENFrequency = (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord)this.ssENFrequency.Duplicate();
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
if (head == "frequency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Frequency")) variable.Value = ssENFrequency; else variable.Optimized = true;
variable.SetFieldName("frequency");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFrequency.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFrequency.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFrequency) {
return ssENFrequency;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFrequency.Key.AsGuid) {
return ssENFrequency;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFrequency.FillFromOther((IRecord) other.AttributeGet(IdFrequency));
}
} // RC_f2c609d858f8411e75fbedee60c5dddf
/// <summary>
/// RecordList type <code>FrequencyRecordList</code> that represents a record list of
///  <code>Frequency</code>
/// </summary>
public partial class RL_86161aa08f9858d205ef72cffcb4919d : GenericRecordList<RC_f2c609d858f8411e75fbedee60c5dddf>, IEnumerable, IEnumerator {

protected override RC_f2c609d858f8411e75fbedee60c5dddf GetElementDefaultValue() {
return new RC_f2c609d858f8411e75fbedee60c5dddf();
}

public T[] ToArray<T>(Func<RC_f2c609d858f8411e75fbedee60c5dddf, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_86161aa08f9858d205ef72cffcb4919d recordList, Func<RC_f2c609d858f8411e75fbedee60c5dddf, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_86161aa08f9858d205ef72cffcb4919d(RC_f2c609d858f8411e75fbedee60c5dddf[] array) {
  RL_86161aa08f9858d205ef72cffcb4919d result = new RL_86161aa08f9858d205ef72cffcb4919d();
result.InnerFromArray(array);
    return result;
}

public static RL_86161aa08f9858d205ef72cffcb4919d ToList<T>(T[] array, Func <T, RC_f2c609d858f8411e75fbedee60c5dddf> converter) {
  RL_86161aa08f9858d205ef72cffcb4919d result = new RL_86161aa08f9858d205ef72cffcb4919d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_86161aa08f9858d205ef72cffcb4919d FromRestList<T>(RestList<T> restList, Func <T, RC_f2c609d858f8411e75fbedee60c5dddf> converter) {
  RL_86161aa08f9858d205ef72cffcb4919d result = new RL_86161aa08f9858d205ef72cffcb4919d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_86161aa08f9858d205ef72cffcb4919d() : base() {
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
protected override OSList<RC_f2c609d858f8411e75fbedee60c5dddf> NewList() {
return new RL_86161aa08f9858d205ef72cffcb4919d();
}


} // RL_86161aa08f9858d205ef72cffcb4919d
}

