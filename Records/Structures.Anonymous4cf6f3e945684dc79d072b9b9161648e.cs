namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6fP2TGhFx02dByubkWFkjg)
///  <code>RC_44242c40a1e3a9d6bd98185caff1a7b9</code> that represents <code>FileStructRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FileStructRecord
public partial struct RC_44242c40a1e3a9d6bd98185caff1a7b9 : ITypedRecord<RC_44242c40a1e3a9d6bd98185caff1a7b9> {
internal static readonly GlobalObjectKey IdFileStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QCwkROOh1qm9mBhcr_GnuQ");

public ST_a158c76eb93396680623c04244f48b6cStructure ssSTFileStruct;


public static implicit operator ST_a158c76eb93396680623c04244f48b6cStructure( RC_44242c40a1e3a9d6bd98185caff1a7b9 r) {
return r.ssSTFileStruct;
}

public static implicit operator RC_44242c40a1e3a9d6bd98185caff1a7b9 (ST_a158c76eb93396680623c04244f48b6cStructure r) {
RC_44242c40a1e3a9d6bd98185caff1a7b9 res = new RC_44242c40a1e3a9d6bd98185caff1a7b9 ();
res.ssSTFileStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_44242c40a1e3a9d6bd98185caff1a7b9() {
OptimizedAttributes = null;
ssSTFileStruct = new ST_a158c76eb93396680623c04244f48b6cStructure();
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
    ssSTFileStruct.OptimizedAttributes = value[0];
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
ssSTFileStruct.Read( r, ref index);
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
public void ReadIM(RC_44242c40a1e3a9d6bd98185caff1a7b9 r) {
this = r;
}


public static bool operator == (RC_44242c40a1e3a9d6bd98185caff1a7b9 a, RC_44242c40a1e3a9d6bd98185caff1a7b9 b) {
if (a.ssSTFileStruct != b.ssSTFileStruct) return false;
return true;
}

public static bool operator != (RC_44242c40a1e3a9d6bd98185caff1a7b9 a, RC_44242c40a1e3a9d6bd98185caff1a7b9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_44242c40a1e3a9d6bd98185caff1a7b9)) return false;
return (this == (RC_44242c40a1e3a9d6bd98185caff1a7b9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFileStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFileStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFileStruct.InternalRecursiveSave();
}


public RC_44242c40a1e3a9d6bd98185caff1a7b9 Duplicate() {
RC_44242c40a1e3a9d6bd98185caff1a7b9 t;
t.ssSTFileStruct = (ST_a158c76eb93396680623c04244f48b6cStructure)this.ssSTFileStruct.Duplicate();
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
if (head == "filestruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileStruct")) variable.Value = ssSTFileStruct; else variable.Optimized = true;
variable.SetFieldName("filestruct");
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
if (key == IdFileStruct) {
return ssSTFileStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFileStruct.Key.AsGuid) {
return ssSTFileStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFileStruct.FillFromOther((IRecord) other.AttributeGet(IdFileStruct));
}
} // RC_44242c40a1e3a9d6bd98185caff1a7b9
/// <summary>
/// RecordList type <code>FileStructRecordList</code> that represents a record list of
///  <code>FileStruct</code>
/// </summary>
public partial class RL_33a0b8b86faa299b5829d2bbdb82260d : GenericRecordList<RC_44242c40a1e3a9d6bd98185caff1a7b9>, IEnumerable, IEnumerator {

protected override RC_44242c40a1e3a9d6bd98185caff1a7b9 GetElementDefaultValue() {
return new RC_44242c40a1e3a9d6bd98185caff1a7b9();
}

public T[] ToArray<T>(Func<RC_44242c40a1e3a9d6bd98185caff1a7b9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_33a0b8b86faa299b5829d2bbdb82260d recordList, Func<RC_44242c40a1e3a9d6bd98185caff1a7b9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_33a0b8b86faa299b5829d2bbdb82260d(RC_44242c40a1e3a9d6bd98185caff1a7b9[] array) {
  RL_33a0b8b86faa299b5829d2bbdb82260d result = new RL_33a0b8b86faa299b5829d2bbdb82260d();
result.InnerFromArray(array);
    return result;
}

public static RL_33a0b8b86faa299b5829d2bbdb82260d ToList<T>(T[] array, Func <T, RC_44242c40a1e3a9d6bd98185caff1a7b9> converter) {
  RL_33a0b8b86faa299b5829d2bbdb82260d result = new RL_33a0b8b86faa299b5829d2bbdb82260d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_33a0b8b86faa299b5829d2bbdb82260d FromRestList<T>(RestList<T> restList, Func <T, RC_44242c40a1e3a9d6bd98185caff1a7b9> converter) {
  RL_33a0b8b86faa299b5829d2bbdb82260d result = new RL_33a0b8b86faa299b5829d2bbdb82260d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_33a0b8b86faa299b5829d2bbdb82260d() : base() {
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
protected override OSList<RC_44242c40a1e3a9d6bd98185caff1a7b9> NewList() {
return new RL_33a0b8b86faa299b5829d2bbdb82260d();
}


} // RL_33a0b8b86faa299b5829d2bbdb82260d
}

