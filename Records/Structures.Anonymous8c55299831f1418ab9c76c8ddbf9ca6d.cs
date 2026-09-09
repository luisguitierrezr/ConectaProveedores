namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mClVjPExikG5x2yN2_nKbQ)
///  <code>RC_8829c69b982d43adb31362f6b3095470</code> that represent
/// s <code>Entra_Workflow_UserlistRecord</code> <p>Description: </p>
/// </summary>
// Name: Entra_Workflow_UserlistRecord
public partial struct RC_8829c69b982d43adb31362f6b3095470 : ITypedRecord<RC_8829c69b982d43adb31362f6b3095470> {
internal static readonly GlobalObjectKey IdEntra_Workflow_Userlist = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*m8YpiC2YrUOzE2L2swlUcA");

public ST_34625f5643caa3d12448dcec7dd4c7d3Structure ssSTEntra_Workflow_Userlist;


public static implicit operator ST_34625f5643caa3d12448dcec7dd4c7d3Structure( RC_8829c69b982d43adb31362f6b3095470 r) {
return r.ssSTEntra_Workflow_Userlist;
}

public static implicit operator RC_8829c69b982d43adb31362f6b3095470 (ST_34625f5643caa3d12448dcec7dd4c7d3Structure r) {
RC_8829c69b982d43adb31362f6b3095470 res = new RC_8829c69b982d43adb31362f6b3095470 ();
res.ssSTEntra_Workflow_Userlist = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8829c69b982d43adb31362f6b3095470() {
OptimizedAttributes = null;
ssSTEntra_Workflow_Userlist = new ST_34625f5643caa3d12448dcec7dd4c7d3Structure();
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
    ssSTEntra_Workflow_Userlist.OptimizedAttributes = value[0];
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
ssSTEntra_Workflow_Userlist.Read( r, ref index);
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
public void ReadIM(RC_8829c69b982d43adb31362f6b3095470 r) {
this = r;
}


public static bool operator == (RC_8829c69b982d43adb31362f6b3095470 a, RC_8829c69b982d43adb31362f6b3095470 b) {
if (a.ssSTEntra_Workflow_Userlist != b.ssSTEntra_Workflow_Userlist) return false;
return true;
}

public static bool operator != (RC_8829c69b982d43adb31362f6b3095470 a, RC_8829c69b982d43adb31362f6b3095470 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8829c69b982d43adb31362f6b3095470)) return false;
return (this == (RC_8829c69b982d43adb31362f6b3095470)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEntra_Workflow_Userlist.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEntra_Workflow_Userlist.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEntra_Workflow_Userlist.InternalRecursiveSave();
}


public RC_8829c69b982d43adb31362f6b3095470 Duplicate() {
RC_8829c69b982d43adb31362f6b3095470 t;
t.ssSTEntra_Workflow_Userlist = (ST_34625f5643caa3d12448dcec7dd4c7d3Structure)this.ssSTEntra_Workflow_Userlist.Duplicate();
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
if (head == "entra_workflow_userlist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Entra_Workflow_Userlist")) variable.Value = ssSTEntra_Workflow_Userlist; else variable.Optimized = true;
variable.SetFieldName("entra_workflow_userlist");
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
if (key == IdEntra_Workflow_Userlist) {
return ssSTEntra_Workflow_Userlist;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntra_Workflow_Userlist.Key.AsGuid) {
return ssSTEntra_Workflow_Userlist;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEntra_Workflow_Userlist.FillFromOther((IRecord) other.AttributeGet(IdEntra_Workflow_Userlist));
}
} // RC_8829c69b982d43adb31362f6b3095470
/// <summary>
/// RecordList type <code>Entra_Workflow_UserlistRecordList</code> that represents a record list of
///  <code>Entra_Workflow_Userlist</code>
/// </summary>
public partial class RL_ff2533a875968ea3b9ff2f069b94b622 : GenericRecordList<RC_8829c69b982d43adb31362f6b3095470>, IEnumerable, IEnumerator {

protected override RC_8829c69b982d43adb31362f6b3095470 GetElementDefaultValue() {
return new RC_8829c69b982d43adb31362f6b3095470();
}

public T[] ToArray<T>(Func<RC_8829c69b982d43adb31362f6b3095470, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ff2533a875968ea3b9ff2f069b94b622 recordList, Func<RC_8829c69b982d43adb31362f6b3095470, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ff2533a875968ea3b9ff2f069b94b622(RC_8829c69b982d43adb31362f6b3095470[] array) {
  RL_ff2533a875968ea3b9ff2f069b94b622 result = new RL_ff2533a875968ea3b9ff2f069b94b622();
result.InnerFromArray(array);
    return result;
}

public static RL_ff2533a875968ea3b9ff2f069b94b622 ToList<T>(T[] array, Func <T, RC_8829c69b982d43adb31362f6b3095470> converter) {
  RL_ff2533a875968ea3b9ff2f069b94b622 result = new RL_ff2533a875968ea3b9ff2f069b94b622();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ff2533a875968ea3b9ff2f069b94b622 FromRestList<T>(RestList<T> restList, Func <T, RC_8829c69b982d43adb31362f6b3095470> converter) {
  RL_ff2533a875968ea3b9ff2f069b94b622 result = new RL_ff2533a875968ea3b9ff2f069b94b622();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ff2533a875968ea3b9ff2f069b94b622() : base() {
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
protected override OSList<RC_8829c69b982d43adb31362f6b3095470> NewList() {
return new RL_ff2533a875968ea3b9ff2f069b94b622();
}


} // RL_ff2533a875968ea3b9ff2f069b94b622
}

