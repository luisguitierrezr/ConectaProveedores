namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (E15K64VMbEuxvD1BRkc8ww)
///  <code>RC_48bcd641416d010841cadd26ba5d55da</code> that represents <code>DecimalRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DecimalRecord
public partial struct RC_48bcd641416d010841cadd26ba5d55da : ITypedRecord<RC_48bcd641416d010841cadd26ba5d55da> {
internal static readonly GlobalObjectKey IdDecimal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Qda8SG1BCAFByt0mul1V2g");

public ST_18874ac0b41f9a239dad794ccac4f8d3Structure ssSTDecimal;


public static implicit operator ST_18874ac0b41f9a239dad794ccac4f8d3Structure( RC_48bcd641416d010841cadd26ba5d55da r) {
return r.ssSTDecimal;
}

public static implicit operator RC_48bcd641416d010841cadd26ba5d55da (ST_18874ac0b41f9a239dad794ccac4f8d3Structure r) {
RC_48bcd641416d010841cadd26ba5d55da res = new RC_48bcd641416d010841cadd26ba5d55da ();
res.ssSTDecimal = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_48bcd641416d010841cadd26ba5d55da() {
OptimizedAttributes = null;
ssSTDecimal = new ST_18874ac0b41f9a239dad794ccac4f8d3Structure();
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
    ssSTDecimal.OptimizedAttributes = value[0];
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
ssSTDecimal.Read( r, ref index);
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
public void ReadIM(RC_48bcd641416d010841cadd26ba5d55da r) {
this = r;
}


public static bool operator == (RC_48bcd641416d010841cadd26ba5d55da a, RC_48bcd641416d010841cadd26ba5d55da b) {
if (a.ssSTDecimal != b.ssSTDecimal) return false;
return true;
}

public static bool operator != (RC_48bcd641416d010841cadd26ba5d55da a, RC_48bcd641416d010841cadd26ba5d55da b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_48bcd641416d010841cadd26ba5d55da)) return false;
return (this == (RC_48bcd641416d010841cadd26ba5d55da)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDecimal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDecimal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDecimal.InternalRecursiveSave();
}


public RC_48bcd641416d010841cadd26ba5d55da Duplicate() {
RC_48bcd641416d010841cadd26ba5d55da t;
t.ssSTDecimal = (ST_18874ac0b41f9a239dad794ccac4f8d3Structure)this.ssSTDecimal.Duplicate();
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
if (head == "decimal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Decimal")) variable.Value = ssSTDecimal; else variable.Optimized = true;
variable.SetFieldName("decimal");
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
if (key == IdDecimal) {
return ssSTDecimal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDecimal.Key.AsGuid) {
return ssSTDecimal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDecimal.FillFromOther((IRecord) other.AttributeGet(IdDecimal));
}
} // RC_48bcd641416d010841cadd26ba5d55da
/// <summary>
/// RecordList type <code>DecimalRecordList</code> that represents a record list of
///  <code>Decimal</code>
/// </summary>
public partial class RL_0b8b481397d3c2af696e2a2d3956b721 : GenericRecordList<RC_48bcd641416d010841cadd26ba5d55da>, IEnumerable, IEnumerator {

protected override RC_48bcd641416d010841cadd26ba5d55da GetElementDefaultValue() {
return new RC_48bcd641416d010841cadd26ba5d55da();
}

public T[] ToArray<T>(Func<RC_48bcd641416d010841cadd26ba5d55da, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0b8b481397d3c2af696e2a2d3956b721 recordList, Func<RC_48bcd641416d010841cadd26ba5d55da, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0b8b481397d3c2af696e2a2d3956b721(RC_48bcd641416d010841cadd26ba5d55da[] array) {
  RL_0b8b481397d3c2af696e2a2d3956b721 result = new RL_0b8b481397d3c2af696e2a2d3956b721();
result.InnerFromArray(array);
    return result;
}

public static RL_0b8b481397d3c2af696e2a2d3956b721 ToList<T>(T[] array, Func <T, RC_48bcd641416d010841cadd26ba5d55da> converter) {
  RL_0b8b481397d3c2af696e2a2d3956b721 result = new RL_0b8b481397d3c2af696e2a2d3956b721();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0b8b481397d3c2af696e2a2d3956b721 FromRestList<T>(RestList<T> restList, Func <T, RC_48bcd641416d010841cadd26ba5d55da> converter) {
  RL_0b8b481397d3c2af696e2a2d3956b721 result = new RL_0b8b481397d3c2af696e2a2d3956b721();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0b8b481397d3c2af696e2a2d3956b721() : base() {
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
protected override OSList<RC_48bcd641416d010841cadd26ba5d55da> NewList() {
return new RL_0b8b481397d3c2af696e2a2d3956b721();
}


} // RL_0b8b481397d3c2af696e2a2d3956b721
}

