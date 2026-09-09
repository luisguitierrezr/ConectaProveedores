namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (xWQvquzIsUGNPkE3PBL9MQ)
///  <code>RC_327e36bc408edd046ca40df8a4e734bb</code> that represent
/// s <code>DatePickerOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: DatePickerOptionalConfigsRecord
public partial struct RC_327e36bc408edd046ca40df8a4e734bb : ITypedRecord<RC_327e36bc408edd046ca40df8a4e734bb> {
internal static readonly GlobalObjectKey IdDatePickerOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vDZ+Mo5ABN1spA34pOc0uw");

public ST_bc4abb4233d9ce894e855c520a20c76fStructure ssSTDatePickerOptionalConfigs;


public static implicit operator ST_bc4abb4233d9ce894e855c520a20c76fStructure( RC_327e36bc408edd046ca40df8a4e734bb r) {
return r.ssSTDatePickerOptionalConfigs;
}

public static implicit operator RC_327e36bc408edd046ca40df8a4e734bb (ST_bc4abb4233d9ce894e855c520a20c76fStructure r) {
RC_327e36bc408edd046ca40df8a4e734bb res = new RC_327e36bc408edd046ca40df8a4e734bb ();
res.ssSTDatePickerOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_327e36bc408edd046ca40df8a4e734bb() {
OptimizedAttributes = null;
ssSTDatePickerOptionalConfigs = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
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
    ssSTDatePickerOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTDatePickerOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_327e36bc408edd046ca40df8a4e734bb r) {
this = r;
}


public static bool operator == (RC_327e36bc408edd046ca40df8a4e734bb a, RC_327e36bc408edd046ca40df8a4e734bb b) {
if (a.ssSTDatePickerOptionalConfigs != b.ssSTDatePickerOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_327e36bc408edd046ca40df8a4e734bb a, RC_327e36bc408edd046ca40df8a4e734bb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_327e36bc408edd046ca40df8a4e734bb)) return false;
return (this == (RC_327e36bc408edd046ca40df8a4e734bb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDatePickerOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDatePickerOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDatePickerOptionalConfigs.InternalRecursiveSave();
}


public RC_327e36bc408edd046ca40df8a4e734bb Duplicate() {
RC_327e36bc408edd046ca40df8a4e734bb t;
t.ssSTDatePickerOptionalConfigs = (ST_bc4abb4233d9ce894e855c520a20c76fStructure)this.ssSTDatePickerOptionalConfigs.Duplicate();
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
if (head == "datepickeroptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DatePickerOptionalConfigs")) variable.Value = ssSTDatePickerOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("datepickeroptionalconfigs");
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
if (key == IdDatePickerOptionalConfigs) {
return ssSTDatePickerOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDatePickerOptionalConfigs.Key.AsGuid) {
return ssSTDatePickerOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDatePickerOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdDatePickerOptionalConfigs));
}
} // RC_327e36bc408edd046ca40df8a4e734bb
/// <summary>
/// RecordList type <code>DatePickerOptionalConfigsRecordList</code> that represents a record list of
///  <code>DatePickerOptionalConfigs</code>
/// </summary>
public partial class RL_bd4587648373bf4d3e2c5fb636046bee : GenericRecordList<RC_327e36bc408edd046ca40df8a4e734bb>, IEnumerable, IEnumerator {

protected override RC_327e36bc408edd046ca40df8a4e734bb GetElementDefaultValue() {
return new RC_327e36bc408edd046ca40df8a4e734bb();
}

public T[] ToArray<T>(Func<RC_327e36bc408edd046ca40df8a4e734bb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bd4587648373bf4d3e2c5fb636046bee recordList, Func<RC_327e36bc408edd046ca40df8a4e734bb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bd4587648373bf4d3e2c5fb636046bee(RC_327e36bc408edd046ca40df8a4e734bb[] array) {
  RL_bd4587648373bf4d3e2c5fb636046bee result = new RL_bd4587648373bf4d3e2c5fb636046bee();
result.InnerFromArray(array);
    return result;
}

public static RL_bd4587648373bf4d3e2c5fb636046bee ToList<T>(T[] array, Func <T, RC_327e36bc408edd046ca40df8a4e734bb> converter) {
  RL_bd4587648373bf4d3e2c5fb636046bee result = new RL_bd4587648373bf4d3e2c5fb636046bee();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bd4587648373bf4d3e2c5fb636046bee FromRestList<T>(RestList<T> restList, Func <T, RC_327e36bc408edd046ca40df8a4e734bb> converter) {
  RL_bd4587648373bf4d3e2c5fb636046bee result = new RL_bd4587648373bf4d3e2c5fb636046bee();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bd4587648373bf4d3e2c5fb636046bee() : base() {
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
protected override OSList<RC_327e36bc408edd046ca40df8a4e734bb> NewList() {
return new RL_bd4587648373bf4d3e2c5fb636046bee();
}


} // RL_bd4587648373bf4d3e2c5fb636046bee
}

