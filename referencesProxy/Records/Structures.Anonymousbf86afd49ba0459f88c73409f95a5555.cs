namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (1K+Gv6Cbn0WIxzQJ+VpVVQ)
///  <code>RC_310dae2b4d3a1f1ded7570a6ee74f16e</code> that represent
/// s <code>DatePickerRangeOptionalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: DatePickerRangeOptionalConfigsRecord
public partial struct RC_310dae2b4d3a1f1ded7570a6ee74f16e : ITypedRecord<RC_310dae2b4d3a1f1ded7570a6ee74f16e> {
internal static readonly GlobalObjectKey IdDatePickerRangeOptionalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*K64NMTpNHR_tdXCm7nTxbg");

public ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure ssSTDatePickerRangeOptionalConfigs;


public static implicit operator ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure( RC_310dae2b4d3a1f1ded7570a6ee74f16e r) {
return r.ssSTDatePickerRangeOptionalConfigs;
}

public static implicit operator RC_310dae2b4d3a1f1ded7570a6ee74f16e (ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure r) {
RC_310dae2b4d3a1f1ded7570a6ee74f16e res = new RC_310dae2b4d3a1f1ded7570a6ee74f16e ();
res.ssSTDatePickerRangeOptionalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_310dae2b4d3a1f1ded7570a6ee74f16e() {
OptimizedAttributes = null;
ssSTDatePickerRangeOptionalConfigs = new ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure();
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
    ssSTDatePickerRangeOptionalConfigs.OptimizedAttributes = value[0];
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
ssSTDatePickerRangeOptionalConfigs.Read( r, ref index);
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
public void ReadIM(RC_310dae2b4d3a1f1ded7570a6ee74f16e r) {
this = r;
}


public static bool operator == (RC_310dae2b4d3a1f1ded7570a6ee74f16e a, RC_310dae2b4d3a1f1ded7570a6ee74f16e b) {
if (a.ssSTDatePickerRangeOptionalConfigs != b.ssSTDatePickerRangeOptionalConfigs) return false;
return true;
}

public static bool operator != (RC_310dae2b4d3a1f1ded7570a6ee74f16e a, RC_310dae2b4d3a1f1ded7570a6ee74f16e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_310dae2b4d3a1f1ded7570a6ee74f16e)) return false;
return (this == (RC_310dae2b4d3a1f1ded7570a6ee74f16e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDatePickerRangeOptionalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDatePickerRangeOptionalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDatePickerRangeOptionalConfigs.InternalRecursiveSave();
}


public RC_310dae2b4d3a1f1ded7570a6ee74f16e Duplicate() {
RC_310dae2b4d3a1f1ded7570a6ee74f16e t;
t.ssSTDatePickerRangeOptionalConfigs = (ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure)this.ssSTDatePickerRangeOptionalConfigs.Duplicate();
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
if (head == "datepickerrangeoptionalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DatePickerRangeOptionalConfigs")) variable.Value = ssSTDatePickerRangeOptionalConfigs; else variable.Optimized = true;
variable.SetFieldName("datepickerrangeoptionalconfigs");
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
if (key == IdDatePickerRangeOptionalConfigs) {
return ssSTDatePickerRangeOptionalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDatePickerRangeOptionalConfigs.Key.AsGuid) {
return ssSTDatePickerRangeOptionalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDatePickerRangeOptionalConfigs.FillFromOther((IRecord) other.AttributeGet(IdDatePickerRangeOptionalConfigs));
}
} // RC_310dae2b4d3a1f1ded7570a6ee74f16e
/// <summary>
/// RecordList type <code>DatePickerRangeOptionalConfigsRecordList</code> that represents a record list
///  of <code>DatePickerRangeOptionalConfigs</code>
/// </summary>
public partial class RL_662f9a01faab4debe4196401f9ed4c71 : GenericRecordList<RC_310dae2b4d3a1f1ded7570a6ee74f16e>, IEnumerable, IEnumerator {

protected override RC_310dae2b4d3a1f1ded7570a6ee74f16e GetElementDefaultValue() {
return new RC_310dae2b4d3a1f1ded7570a6ee74f16e();
}

public T[] ToArray<T>(Func<RC_310dae2b4d3a1f1ded7570a6ee74f16e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_662f9a01faab4debe4196401f9ed4c71 recordList, Func<RC_310dae2b4d3a1f1ded7570a6ee74f16e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_662f9a01faab4debe4196401f9ed4c71(RC_310dae2b4d3a1f1ded7570a6ee74f16e[] array) {
  RL_662f9a01faab4debe4196401f9ed4c71 result = new RL_662f9a01faab4debe4196401f9ed4c71();
result.InnerFromArray(array);
    return result;
}

public static RL_662f9a01faab4debe4196401f9ed4c71 ToList<T>(T[] array, Func <T, RC_310dae2b4d3a1f1ded7570a6ee74f16e> converter) {
  RL_662f9a01faab4debe4196401f9ed4c71 result = new RL_662f9a01faab4debe4196401f9ed4c71();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_662f9a01faab4debe4196401f9ed4c71 FromRestList<T>(RestList<T> restList, Func <T, RC_310dae2b4d3a1f1ded7570a6ee74f16e> converter) {
  RL_662f9a01faab4debe4196401f9ed4c71 result = new RL_662f9a01faab4debe4196401f9ed4c71();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_662f9a01faab4debe4196401f9ed4c71() : base() {
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
protected override OSList<RC_310dae2b4d3a1f1ded7570a6ee74f16e> NewList() {
return new RL_662f9a01faab4debe4196401f9ed4c71();
}


} // RL_662f9a01faab4debe4196401f9ed4c71
}

