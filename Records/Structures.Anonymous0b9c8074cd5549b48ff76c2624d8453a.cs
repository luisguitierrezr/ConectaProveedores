namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (dICcC1XNtEmP92wmJNhFOg)
///  <code>RC_d979b4500d349dbbb37ac9f2fd2a6d68</code> that represent
/// s <code>User_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: User_Extended_InternalRecord
public partial struct RC_d979b4500d349dbbb37ac9f2fd2a6d68 : ITypedRecord<RC_d979b4500d349dbbb37ac9f2fd2a6d68> {
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public static implicit operator EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord( RC_d979b4500d349dbbb37ac9f2fd2a6d68 r) {
return r.ssENUser_Extended_Internal;
}

public static implicit operator RC_d979b4500d349dbbb37ac9f2fd2a6d68 (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord r) {
RC_d979b4500d349dbbb37ac9f2fd2a6d68 res = new RC_d979b4500d349dbbb37ac9f2fd2a6d68 ();
res.ssENUser_Extended_Internal = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENUser_Extended_Internal.ChangedAttributes = value;
}
get {
    return ssENUser_Extended_Internal.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d979b4500d349dbbb37ac9f2fd2a6d68() {
OptimizedAttributes = null;
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENUser_Extended_Internal.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENUser_Extended_Internal.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_d979b4500d349dbbb37ac9f2fd2a6d68 r) {
this = r;
}


public static bool operator == (RC_d979b4500d349dbbb37ac9f2fd2a6d68 a, RC_d979b4500d349dbbb37ac9f2fd2a6d68 b) {
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_d979b4500d349dbbb37ac9f2fd2a6d68 a, RC_d979b4500d349dbbb37ac9f2fd2a6d68 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d979b4500d349dbbb37ac9f2fd2a6d68)) return false;
return (this == (RC_d979b4500d349dbbb37ac9f2fd2a6d68)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_d979b4500d349dbbb37ac9f2fd2a6d68 Duplicate() {
RC_d979b4500d349dbbb37ac9f2fd2a6d68 t;
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
if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENUser_Extended_Internal.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENUser_Extended_Internal.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_d979b4500d349dbbb37ac9f2fd2a6d68
/// <summary>
/// RecordList type <code>User_Extended_InternalRecordList</code> that represents a record list of
///  <code>User_Extended_Internal</code>
/// </summary>
public partial class RL_216ae81da35dfe5cfaaa600823fb4c79 : GenericRecordList<RC_d979b4500d349dbbb37ac9f2fd2a6d68>, IEnumerable, IEnumerator {

protected override RC_d979b4500d349dbbb37ac9f2fd2a6d68 GetElementDefaultValue() {
return new RC_d979b4500d349dbbb37ac9f2fd2a6d68();
}

public T[] ToArray<T>(Func<RC_d979b4500d349dbbb37ac9f2fd2a6d68, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_216ae81da35dfe5cfaaa600823fb4c79 recordList, Func<RC_d979b4500d349dbbb37ac9f2fd2a6d68, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_216ae81da35dfe5cfaaa600823fb4c79(RC_d979b4500d349dbbb37ac9f2fd2a6d68[] array) {
  RL_216ae81da35dfe5cfaaa600823fb4c79 result = new RL_216ae81da35dfe5cfaaa600823fb4c79();
result.InnerFromArray(array);
    return result;
}

public static RL_216ae81da35dfe5cfaaa600823fb4c79 ToList<T>(T[] array, Func <T, RC_d979b4500d349dbbb37ac9f2fd2a6d68> converter) {
  RL_216ae81da35dfe5cfaaa600823fb4c79 result = new RL_216ae81da35dfe5cfaaa600823fb4c79();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_216ae81da35dfe5cfaaa600823fb4c79 FromRestList<T>(RestList<T> restList, Func <T, RC_d979b4500d349dbbb37ac9f2fd2a6d68> converter) {
  RL_216ae81da35dfe5cfaaa600823fb4c79 result = new RL_216ae81da35dfe5cfaaa600823fb4c79();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_216ae81da35dfe5cfaaa600823fb4c79() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d979b4500d349dbbb37ac9f2fd2a6d68> NewList() {
return new RL_216ae81da35dfe5cfaaa600823fb4c79();
}


} // RL_216ae81da35dfe5cfaaa600823fb4c79
}

