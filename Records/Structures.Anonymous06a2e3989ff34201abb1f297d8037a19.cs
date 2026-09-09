namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mOOiBvOfAUKrsfKX2AN6GQ)
///  <code>RC_00310a262abd8758c59d6849f2a2be40</code> that represent
/// s <code>ActionTimestampsRecord</code> <p>Description: </p>
/// </summary>
// Name: ActionTimestampsRecord
public partial struct RC_00310a262abd8758c59d6849f2a2be40 : ITypedRecord<RC_00310a262abd8758c59d6849f2a2be40> {
internal static readonly GlobalObjectKey IdActionTimestamps = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*JgoxAL0qWIfFnWhJ8qK+QA");

public EN_b22d64c90281d09a316b6f4502a74326EntityRecord ssENActionTimestamps;


public static implicit operator EN_b22d64c90281d09a316b6f4502a74326EntityRecord( RC_00310a262abd8758c59d6849f2a2be40 r) {
return r.ssENActionTimestamps;
}

public static implicit operator RC_00310a262abd8758c59d6849f2a2be40 (EN_b22d64c90281d09a316b6f4502a74326EntityRecord r) {
RC_00310a262abd8758c59d6849f2a2be40 res = new RC_00310a262abd8758c59d6849f2a2be40 ();
res.ssENActionTimestamps = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENActionTimestamps.ChangedAttributes = value;
}
get {
    return ssENActionTimestamps.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_00310a262abd8758c59d6849f2a2be40() {
OptimizedAttributes = null;
ssENActionTimestamps = new EN_b22d64c90281d09a316b6f4502a74326EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENActionTimestamps.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENActionTimestamps.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENActionTimestamps.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENActionTimestamps.Read( r, ref index);
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
public void ReadIM(RC_00310a262abd8758c59d6849f2a2be40 r) {
this = r;
}


public static bool operator == (RC_00310a262abd8758c59d6849f2a2be40 a, RC_00310a262abd8758c59d6849f2a2be40 b) {
if (a.ssENActionTimestamps != b.ssENActionTimestamps) return false;
return true;
}

public static bool operator != (RC_00310a262abd8758c59d6849f2a2be40 a, RC_00310a262abd8758c59d6849f2a2be40 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_00310a262abd8758c59d6849f2a2be40)) return false;
return (this == (RC_00310a262abd8758c59d6849f2a2be40)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENActionTimestamps.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENActionTimestamps.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENActionTimestamps.InternalRecursiveSave();
}


public RC_00310a262abd8758c59d6849f2a2be40 Duplicate() {
RC_00310a262abd8758c59d6849f2a2be40 t;
t.ssENActionTimestamps = (EN_b22d64c90281d09a316b6f4502a74326EntityRecord)this.ssENActionTimestamps.Duplicate();
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
if (head == "actiontimestamps") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActionTimestamps")) variable.Value = ssENActionTimestamps; else variable.Optimized = true;
variable.SetFieldName("actiontimestamps");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENActionTimestamps.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENActionTimestamps.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdActionTimestamps) {
return ssENActionTimestamps;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActionTimestamps.Key.AsGuid) {
return ssENActionTimestamps;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENActionTimestamps.FillFromOther((IRecord) other.AttributeGet(IdActionTimestamps));
}
} // RC_00310a262abd8758c59d6849f2a2be40
/// <summary>
/// RecordList type <code>ActionTimestampsRecordList</code> that represents a record list of
///  <code>ActionTimestamps</code>
/// </summary>
public partial class RL_13faa545ce925ae37def82ba33666b71 : GenericRecordList<RC_00310a262abd8758c59d6849f2a2be40>, IEnumerable, IEnumerator {

protected override RC_00310a262abd8758c59d6849f2a2be40 GetElementDefaultValue() {
return new RC_00310a262abd8758c59d6849f2a2be40();
}

public T[] ToArray<T>(Func<RC_00310a262abd8758c59d6849f2a2be40, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_13faa545ce925ae37def82ba33666b71 recordList, Func<RC_00310a262abd8758c59d6849f2a2be40, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_13faa545ce925ae37def82ba33666b71(RC_00310a262abd8758c59d6849f2a2be40[] array) {
  RL_13faa545ce925ae37def82ba33666b71 result = new RL_13faa545ce925ae37def82ba33666b71();
result.InnerFromArray(array);
    return result;
}

public static RL_13faa545ce925ae37def82ba33666b71 ToList<T>(T[] array, Func <T, RC_00310a262abd8758c59d6849f2a2be40> converter) {
  RL_13faa545ce925ae37def82ba33666b71 result = new RL_13faa545ce925ae37def82ba33666b71();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_13faa545ce925ae37def82ba33666b71 FromRestList<T>(RestList<T> restList, Func <T, RC_00310a262abd8758c59d6849f2a2be40> converter) {
  RL_13faa545ce925ae37def82ba33666b71 result = new RL_13faa545ce925ae37def82ba33666b71();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_13faa545ce925ae37def82ba33666b71() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_00310a262abd8758c59d6849f2a2be40> NewList() {
return new RL_13faa545ce925ae37def82ba33666b71();
}


} // RL_13faa545ce925ae37def82ba33666b71
}

