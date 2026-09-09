namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (8+L0ASnJYEqcOdDRlzSKXg)
///  <code>RC_07279ed7569c7c3676640051323860d6</code> that represent
/// s <code>CurrentAccountFAC_PAG_OutStructRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrentAccountFAC_PAG_OutStructRecord
public partial struct RC_07279ed7569c7c3676640051323860d6 : ITypedRecord<RC_07279ed7569c7c3676640051323860d6> {
internal static readonly GlobalObjectKey IdCurrentAccountFAC_PAG_OutStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*154nB5xWNnx2ZABRMjhg1g");

public ST_89af93fec4915ac38f0ef9c0a1b729beStructure ssSTCurrentAccountFAC_PAG_OutStruct;


public static implicit operator ST_89af93fec4915ac38f0ef9c0a1b729beStructure( RC_07279ed7569c7c3676640051323860d6 r) {
return r.ssSTCurrentAccountFAC_PAG_OutStruct;
}

public static implicit operator RC_07279ed7569c7c3676640051323860d6 (ST_89af93fec4915ac38f0ef9c0a1b729beStructure r) {
RC_07279ed7569c7c3676640051323860d6 res = new RC_07279ed7569c7c3676640051323860d6 ();
res.ssSTCurrentAccountFAC_PAG_OutStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_07279ed7569c7c3676640051323860d6() {
OptimizedAttributes = null;
ssSTCurrentAccountFAC_PAG_OutStruct = new ST_89af93fec4915ac38f0ef9c0a1b729beStructure();
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
    ssSTCurrentAccountFAC_PAG_OutStruct.OptimizedAttributes = value[0];
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
ssSTCurrentAccountFAC_PAG_OutStruct.Read( r, ref index);
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
public void ReadIM(RC_07279ed7569c7c3676640051323860d6 r) {
this = r;
}


public static bool operator == (RC_07279ed7569c7c3676640051323860d6 a, RC_07279ed7569c7c3676640051323860d6 b) {
if (a.ssSTCurrentAccountFAC_PAG_OutStruct != b.ssSTCurrentAccountFAC_PAG_OutStruct) return false;
return true;
}

public static bool operator != (RC_07279ed7569c7c3676640051323860d6 a, RC_07279ed7569c7c3676640051323860d6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_07279ed7569c7c3676640051323860d6)) return false;
return (this == (RC_07279ed7569c7c3676640051323860d6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCurrentAccountFAC_PAG_OutStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCurrentAccountFAC_PAG_OutStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCurrentAccountFAC_PAG_OutStruct.InternalRecursiveSave();
}


public RC_07279ed7569c7c3676640051323860d6 Duplicate() {
RC_07279ed7569c7c3676640051323860d6 t;
t.ssSTCurrentAccountFAC_PAG_OutStruct = (ST_89af93fec4915ac38f0ef9c0a1b729beStructure)this.ssSTCurrentAccountFAC_PAG_OutStruct.Duplicate();
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
if (head == "currentaccountfac_pag_outstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrentAccountFAC_PAG_OutStruct")) variable.Value = ssSTCurrentAccountFAC_PAG_OutStruct; else variable.Optimized = true;
variable.SetFieldName("currentaccountfac_pag_outstruct");
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
if (key == IdCurrentAccountFAC_PAG_OutStruct) {
return ssSTCurrentAccountFAC_PAG_OutStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrentAccountFAC_PAG_OutStruct.Key.AsGuid) {
return ssSTCurrentAccountFAC_PAG_OutStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCurrentAccountFAC_PAG_OutStruct.FillFromOther((IRecord) other.AttributeGet(IdCurrentAccountFAC_PAG_OutStruct));
}
} // RC_07279ed7569c7c3676640051323860d6
/// <summary>
/// RecordList type <code>CurrentAccountFAC_PAG_OutStructRecordList</code> that represents a record
///  list of <code>CurrentAccountFAC_PAG_OutStruct</code>
/// </summary>
public partial class RL_500005bee216c7e18ff728d445b9e65c : GenericRecordList<RC_07279ed7569c7c3676640051323860d6>, IEnumerable, IEnumerator {

protected override RC_07279ed7569c7c3676640051323860d6 GetElementDefaultValue() {
return new RC_07279ed7569c7c3676640051323860d6();
}

public T[] ToArray<T>(Func<RC_07279ed7569c7c3676640051323860d6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_500005bee216c7e18ff728d445b9e65c recordList, Func<RC_07279ed7569c7c3676640051323860d6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_500005bee216c7e18ff728d445b9e65c(RC_07279ed7569c7c3676640051323860d6[] array) {
  RL_500005bee216c7e18ff728d445b9e65c result = new RL_500005bee216c7e18ff728d445b9e65c();
result.InnerFromArray(array);
    return result;
}

public static RL_500005bee216c7e18ff728d445b9e65c ToList<T>(T[] array, Func <T, RC_07279ed7569c7c3676640051323860d6> converter) {
  RL_500005bee216c7e18ff728d445b9e65c result = new RL_500005bee216c7e18ff728d445b9e65c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_500005bee216c7e18ff728d445b9e65c FromRestList<T>(RestList<T> restList, Func <T, RC_07279ed7569c7c3676640051323860d6> converter) {
  RL_500005bee216c7e18ff728d445b9e65c result = new RL_500005bee216c7e18ff728d445b9e65c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_500005bee216c7e18ff728d445b9e65c() : base() {
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
protected override OSList<RC_07279ed7569c7c3676640051323860d6> NewList() {
return new RL_500005bee216c7e18ff728d445b9e65c();
}


} // RL_500005bee216c7e18ff728d445b9e65c
}

