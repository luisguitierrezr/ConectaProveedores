namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (k1TElCYQjUur1WssHIzsrw)
///  <code>RC_34272dae45b4de5e1332f46c6e8700b9</code> that represent
/// s <code>UserUser_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUser_Extended_InternalRecord
public partial struct RC_34272dae45b4de5e1332f46c6e8700b9 : ITypedRecord<RC_34272dae45b4de5e1332f46c6e8700b9> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_34272dae45b4de5e1332f46c6e8700b9() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUser_Extended_Internal.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUser_Extended_Internal.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
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
public void ReadIM(RC_34272dae45b4de5e1332f46c6e8700b9 r) {
this = r;
}


public static bool operator == (RC_34272dae45b4de5e1332f46c6e8700b9 a, RC_34272dae45b4de5e1332f46c6e8700b9 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_34272dae45b4de5e1332f46c6e8700b9 a, RC_34272dae45b4de5e1332f46c6e8700b9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_34272dae45b4de5e1332f46c6e8700b9)) return false;
return (this == (RC_34272dae45b4de5e1332f46c6e8700b9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_34272dae45b4de5e1332f46c6e8700b9 Duplicate() {
RC_34272dae45b4de5e1332f46c6e8700b9 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_34272dae45b4de5e1332f46c6e8700b9
/// <summary>
/// RecordList type <code>UserUser_Extended_InternalRecordList</code> that represents a record list of
///  <code>User, User_Extended_Internal</code>
/// </summary>
public partial class RL_752c66ffcb633a1081093541635464e7 : GenericRecordList<RC_34272dae45b4de5e1332f46c6e8700b9>, IEnumerable, IEnumerator {

protected override RC_34272dae45b4de5e1332f46c6e8700b9 GetElementDefaultValue() {
return new RC_34272dae45b4de5e1332f46c6e8700b9();
}

public T[] ToArray<T>(Func<RC_34272dae45b4de5e1332f46c6e8700b9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_752c66ffcb633a1081093541635464e7 recordList, Func<RC_34272dae45b4de5e1332f46c6e8700b9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_752c66ffcb633a1081093541635464e7(RC_34272dae45b4de5e1332f46c6e8700b9[] array) {
  RL_752c66ffcb633a1081093541635464e7 result = new RL_752c66ffcb633a1081093541635464e7();
result.InnerFromArray(array);
    return result;
}

public static RL_752c66ffcb633a1081093541635464e7 ToList<T>(T[] array, Func <T, RC_34272dae45b4de5e1332f46c6e8700b9> converter) {
  RL_752c66ffcb633a1081093541635464e7 result = new RL_752c66ffcb633a1081093541635464e7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_752c66ffcb633a1081093541635464e7 FromRestList<T>(RestList<T> restList, Func <T, RC_34272dae45b4de5e1332f46c6e8700b9> converter) {
  RL_752c66ffcb633a1081093541635464e7 result = new RL_752c66ffcb633a1081093541635464e7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_752c66ffcb633a1081093541635464e7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_34272dae45b4de5e1332f46c6e8700b9> NewList() {
return new RL_752c66ffcb633a1081093541635464e7();
}


} // RL_752c66ffcb633a1081093541635464e7
}

