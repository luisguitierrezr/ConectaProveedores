namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (D6C8XVCG3kW4HlbDnW0NUw)
///  <code>RC_e63ebb69a9e232a6817f4ea671f315f7</code> that represent
/// s <code>ValidationReportAuthorizationRecord</code> <p>Description: </p>
/// </summary>
// Name: ValidationReportAuthorizationRecord
public partial struct RC_e63ebb69a9e232a6817f4ea671f315f7 : ITypedRecord<RC_e63ebb69a9e232a6817f4ea671f315f7> {
internal static readonly GlobalObjectKey IdValidationReportAuthorization = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*abs+5uKppjKBf06mcfMV9w");

public ST_2667ad63792f2349dc9e4a818559d9ecStructure ssSTValidationReportAuthorization;


public static implicit operator ST_2667ad63792f2349dc9e4a818559d9ecStructure( RC_e63ebb69a9e232a6817f4ea671f315f7 r) {
return r.ssSTValidationReportAuthorization;
}

public static implicit operator RC_e63ebb69a9e232a6817f4ea671f315f7 (ST_2667ad63792f2349dc9e4a818559d9ecStructure r) {
RC_e63ebb69a9e232a6817f4ea671f315f7 res = new RC_e63ebb69a9e232a6817f4ea671f315f7 ();
res.ssSTValidationReportAuthorization = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e63ebb69a9e232a6817f4ea671f315f7() {
OptimizedAttributes = null;
ssSTValidationReportAuthorization = new ST_2667ad63792f2349dc9e4a818559d9ecStructure();
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
    ssSTValidationReportAuthorization.OptimizedAttributes = value[0];
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
ssSTValidationReportAuthorization.Read( r, ref index);
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
public void ReadIM(RC_e63ebb69a9e232a6817f4ea671f315f7 r) {
this = r;
}


public static bool operator == (RC_e63ebb69a9e232a6817f4ea671f315f7 a, RC_e63ebb69a9e232a6817f4ea671f315f7 b) {
if (a.ssSTValidationReportAuthorization != b.ssSTValidationReportAuthorization) return false;
return true;
}

public static bool operator != (RC_e63ebb69a9e232a6817f4ea671f315f7 a, RC_e63ebb69a9e232a6817f4ea671f315f7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e63ebb69a9e232a6817f4ea671f315f7)) return false;
return (this == (RC_e63ebb69a9e232a6817f4ea671f315f7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTValidationReportAuthorization.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTValidationReportAuthorization.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTValidationReportAuthorization.InternalRecursiveSave();
}


public RC_e63ebb69a9e232a6817f4ea671f315f7 Duplicate() {
RC_e63ebb69a9e232a6817f4ea671f315f7 t;
t.ssSTValidationReportAuthorization = (ST_2667ad63792f2349dc9e4a818559d9ecStructure)this.ssSTValidationReportAuthorization.Duplicate();
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
if (head == "validationreportauthorization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValidationReportAuthorization")) variable.Value = ssSTValidationReportAuthorization; else variable.Optimized = true;
variable.SetFieldName("validationreportauthorization");
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
if (key == IdValidationReportAuthorization) {
return ssSTValidationReportAuthorization;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValidationReportAuthorization.Key.AsGuid) {
return ssSTValidationReportAuthorization;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTValidationReportAuthorization.FillFromOther((IRecord) other.AttributeGet(IdValidationReportAuthorization));
}
} // RC_e63ebb69a9e232a6817f4ea671f315f7
/// <summary>
/// RecordList type <code>ValidationReportAuthorizationRecordList</code> that represents a record list
///  of <code>ValidationReportAuthorization</code>
/// </summary>
public partial class RL_219713777737ac3137e47cb556541a50 : GenericRecordList<RC_e63ebb69a9e232a6817f4ea671f315f7>, IEnumerable, IEnumerator {

protected override RC_e63ebb69a9e232a6817f4ea671f315f7 GetElementDefaultValue() {
return new RC_e63ebb69a9e232a6817f4ea671f315f7();
}

public T[] ToArray<T>(Func<RC_e63ebb69a9e232a6817f4ea671f315f7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_219713777737ac3137e47cb556541a50 recordList, Func<RC_e63ebb69a9e232a6817f4ea671f315f7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_219713777737ac3137e47cb556541a50(RC_e63ebb69a9e232a6817f4ea671f315f7[] array) {
  RL_219713777737ac3137e47cb556541a50 result = new RL_219713777737ac3137e47cb556541a50();
result.InnerFromArray(array);
    return result;
}

public static RL_219713777737ac3137e47cb556541a50 ToList<T>(T[] array, Func <T, RC_e63ebb69a9e232a6817f4ea671f315f7> converter) {
  RL_219713777737ac3137e47cb556541a50 result = new RL_219713777737ac3137e47cb556541a50();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_219713777737ac3137e47cb556541a50 FromRestList<T>(RestList<T> restList, Func <T, RC_e63ebb69a9e232a6817f4ea671f315f7> converter) {
  RL_219713777737ac3137e47cb556541a50 result = new RL_219713777737ac3137e47cb556541a50();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_219713777737ac3137e47cb556541a50() : base() {
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
protected override OSList<RC_e63ebb69a9e232a6817f4ea671f315f7> NewList() {
return new RL_219713777737ac3137e47cb556541a50();
}


} // RL_219713777737ac3137e47cb556541a50
}

