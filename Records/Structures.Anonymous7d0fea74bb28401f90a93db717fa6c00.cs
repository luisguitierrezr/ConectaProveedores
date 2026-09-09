namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (dOoPfSi7H0CQqT23F_psAA)
///  <code>RC_34d5d5ab5565b38a57ae5f2563a8c466</code> that represent
/// s <code>SeriesStylingOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: SeriesStylingOptionalConfigsRecord
public partial struct RC_34d5d5ab5565b38a57ae5f2563a8c466 : ITypedRecord<RC_34d5d5ab5565b38a57ae5f2563a8c466> {
internal static readonly GlobalObjectKey IdSeriesStylingOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*q9XVNGVVirNXrl8lY6jEZg");

public ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure ssSTSeriesStylingOptionalConfigs;


public static implicit operator ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure( RC_34d5d5ab5565b38a57ae5f2563a8c466 r) {
return r.ssSTSeriesStylingOptionalConfigs;
}

public static implicit operator RC_34d5d5ab5565b38a57ae5f2563a8c466 (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure r) {
RC_34d5d5ab5565b38a57ae5f2563a8c466 res = new RC_34d5d5ab5565b38a57ae5f2563a8c466 ();
res.ssSTSeriesStylingOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_34d5d5ab5565b38a57ae5f2563a8c466() {
OptimizedAttributes = null;
ssSTSeriesStylingOptionalConfigs = new ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure();
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
    ssSTSeriesStylingOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTSeriesStylingOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_34d5d5ab5565b38a57ae5f2563a8c466 r) {
this = r;
}


public static bool operator == (RC_34d5d5ab5565b38a57ae5f2563a8c466 a, RC_34d5d5ab5565b38a57ae5f2563a8c466 b) {
if (a.ssSTSeriesStylingOptionalConfigs != b.ssSTSeriesStylingOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_34d5d5ab5565b38a57ae5f2563a8c466 a, RC_34d5d5ab5565b38a57ae5f2563a8c466 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_34d5d5ab5565b38a57ae5f2563a8c466)) return false;
return (this == (RC_34d5d5ab5565b38a57ae5f2563a8c466)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSeriesStylingOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSeriesStylingOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSeriesStylingOptionalConfigs.InternalRecursiveSave();
}


public RC_34d5d5ab5565b38a57ae5f2563a8c466 Duplicate() {
RC_34d5d5ab5565b38a57ae5f2563a8c466 t;
t.ssSTSeriesStylingOptionalConfigs = (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure)this.ssSTSeriesStylingOptionalConfigs.Duplicate();
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
if (head == "seriesstylingoptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SeriesStylingOptionalConfigs")) variable.Value = ssSTSeriesStylingOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("seriesstylingoptionalconfigs");
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
if (key == IdSeriesStylingOptionalConfigs) {
return ssSTSeriesStylingOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSeriesStylingOptionalConfigs.Key.AsGuid) {
return ssSTSeriesStylingOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSeriesStylingOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdSeriesStylingOptionalConfigs));
}
} // RC_34d5d5ab5565b38a57ae5f2563a8c466
/// <summary>
/// RecordList type <code>SeriesStylingOptionalConfigsRecordList</code> that represents a record list
///  of <code>SeriesStylingOptionalConfigs</code>
/// </summary>
public partial class RL_c00a35e05574e8e9007aafcec77ad537 : GenericRecordList<RC_34d5d5ab5565b38a57ae5f2563a8c466>, IEnumerable, IEnumerator {

protected override RC_34d5d5ab5565b38a57ae5f2563a8c466 GetElementDefaultValue() {
return new RC_34d5d5ab5565b38a57ae5f2563a8c466();
}

public T[] ToArray<T>(Func<RC_34d5d5ab5565b38a57ae5f2563a8c466, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c00a35e05574e8e9007aafcec77ad537 recordList, Func<RC_34d5d5ab5565b38a57ae5f2563a8c466, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c00a35e05574e8e9007aafcec77ad537(RC_34d5d5ab5565b38a57ae5f2563a8c466[] array) {
  RL_c00a35e05574e8e9007aafcec77ad537 result = new RL_c00a35e05574e8e9007aafcec77ad537();
result.InnerFromArray(array);
    return result;
}

public static RL_c00a35e05574e8e9007aafcec77ad537 ToList<T>(T[] array, Func <T, RC_34d5d5ab5565b38a57ae5f2563a8c466> converter) {
  RL_c00a35e05574e8e9007aafcec77ad537 result = new RL_c00a35e05574e8e9007aafcec77ad537();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c00a35e05574e8e9007aafcec77ad537 FromRestList<T>(RestList<T> restList, Func <T, RC_34d5d5ab5565b38a57ae5f2563a8c466> converter) {
  RL_c00a35e05574e8e9007aafcec77ad537 result = new RL_c00a35e05574e8e9007aafcec77ad537();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c00a35e05574e8e9007aafcec77ad537() : base() {
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
protected override OSList<RC_34d5d5ab5565b38a57ae5f2563a8c466> NewList() {
return new RL_c00a35e05574e8e9007aafcec77ad537();
}


} // RL_c00a35e05574e8e9007aafcec77ad537
}

