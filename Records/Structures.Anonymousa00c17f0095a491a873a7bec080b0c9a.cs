namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (8BcMoFoJGkmHOnvsCAsMmg)
///  <code>RC_0a3f9d90df8bd7c726f88030e3651410</code> that represents <code>UserRoleCodeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserRoleCodeRecord
public partial struct RC_0a3f9d90df8bd7c726f88030e3651410 : ITypedRecord<RC_0a3f9d90df8bd7c726f88030e3651410> {
internal static readonly GlobalObjectKey IdUserRoleCode = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kJ0_Covfx9cm+IAw42UUEA");

public ST_e39617f0f094a322d4157f34fe424dadStructure ssSTUserRoleCode;


public static implicit operator ST_e39617f0f094a322d4157f34fe424dadStructure( RC_0a3f9d90df8bd7c726f88030e3651410 r) {
return r.ssSTUserRoleCode;
}

public static implicit operator RC_0a3f9d90df8bd7c726f88030e3651410 (ST_e39617f0f094a322d4157f34fe424dadStructure r) {
RC_0a3f9d90df8bd7c726f88030e3651410 res = new RC_0a3f9d90df8bd7c726f88030e3651410 ();
res.ssSTUserRoleCode = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0a3f9d90df8bd7c726f88030e3651410() {
OptimizedAttributes = null;
ssSTUserRoleCode = new ST_e39617f0f094a322d4157f34fe424dadStructure();
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
    ssSTUserRoleCode.OptimizedAttributes = value[0];
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
ssSTUserRoleCode.Read( r, ref index);
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
public void ReadIM(RC_0a3f9d90df8bd7c726f88030e3651410 r) {
this = r;
}


public static bool operator == (RC_0a3f9d90df8bd7c726f88030e3651410 a, RC_0a3f9d90df8bd7c726f88030e3651410 b) {
if (a.ssSTUserRoleCode != b.ssSTUserRoleCode) return false;
return true;
}

public static bool operator != (RC_0a3f9d90df8bd7c726f88030e3651410 a, RC_0a3f9d90df8bd7c726f88030e3651410 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0a3f9d90df8bd7c726f88030e3651410)) return false;
return (this == (RC_0a3f9d90df8bd7c726f88030e3651410)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUserRoleCode.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUserRoleCode.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUserRoleCode.InternalRecursiveSave();
}


public RC_0a3f9d90df8bd7c726f88030e3651410 Duplicate() {
RC_0a3f9d90df8bd7c726f88030e3651410 t;
t.ssSTUserRoleCode = (ST_e39617f0f094a322d4157f34fe424dadStructure)this.ssSTUserRoleCode.Duplicate();
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
if (head == "userrolecode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserRoleCode")) variable.Value = ssSTUserRoleCode; else variable.Optimized = true;
variable.SetFieldName("userrolecode");
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
if (key == IdUserRoleCode) {
return ssSTUserRoleCode;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserRoleCode.Key.AsGuid) {
return ssSTUserRoleCode;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUserRoleCode.FillFromOther((IRecord) other.AttributeGet(IdUserRoleCode));
}
} // RC_0a3f9d90df8bd7c726f88030e3651410
/// <summary>
/// RecordList type <code>UserRoleCodeRecordList</code> that represents a record list of
///  <code>UserRoleCode</code>
/// </summary>
public partial class RL_a628f44fbe3d61a818adba8c3d848715 : GenericRecordList<RC_0a3f9d90df8bd7c726f88030e3651410>, IEnumerable, IEnumerator {

protected override RC_0a3f9d90df8bd7c726f88030e3651410 GetElementDefaultValue() {
return new RC_0a3f9d90df8bd7c726f88030e3651410();
}

public T[] ToArray<T>(Func<RC_0a3f9d90df8bd7c726f88030e3651410, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a628f44fbe3d61a818adba8c3d848715 recordList, Func<RC_0a3f9d90df8bd7c726f88030e3651410, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a628f44fbe3d61a818adba8c3d848715(RC_0a3f9d90df8bd7c726f88030e3651410[] array) {
  RL_a628f44fbe3d61a818adba8c3d848715 result = new RL_a628f44fbe3d61a818adba8c3d848715();
result.InnerFromArray(array);
    return result;
}

public static RL_a628f44fbe3d61a818adba8c3d848715 ToList<T>(T[] array, Func <T, RC_0a3f9d90df8bd7c726f88030e3651410> converter) {
  RL_a628f44fbe3d61a818adba8c3d848715 result = new RL_a628f44fbe3d61a818adba8c3d848715();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a628f44fbe3d61a818adba8c3d848715 FromRestList<T>(RestList<T> restList, Func <T, RC_0a3f9d90df8bd7c726f88030e3651410> converter) {
  RL_a628f44fbe3d61a818adba8c3d848715 result = new RL_a628f44fbe3d61a818adba8c3d848715();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a628f44fbe3d61a818adba8c3d848715() : base() {
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
protected override OSList<RC_0a3f9d90df8bd7c726f88030e3651410> NewList() {
return new RL_a628f44fbe3d61a818adba8c3d848715();
}


} // RL_a628f44fbe3d61a818adba8c3d848715
}

