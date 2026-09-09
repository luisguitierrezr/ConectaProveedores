namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (aD2_VGomIEWRDuNLz8zsGg)
///  <code>RC_55a4f62f090e92d07d40f0b63ffe2d16</code> that represent
/// s <code>OrderContractFileForeignResidenceOrderFileForeignResidenceRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: OrderContractFileForeignResidenceOrderFileForeignResidenceRecord
public partial struct RC_55a4f62f090e92d07d40f0b63ffe2d16 : ITypedRecord<RC_55a4f62f090e92d07d40f0b63ffe2d16> {
internal static readonly GlobalObjectKey IdOrderContractFileForeignResidence = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eQjDTIR6I0Qg9UzowULR2Q");
internal static readonly GlobalObjectKey IdOrderFileForeignResidence = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sx5WI26jrlY3lrTQF_cvyg");

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFileForeignResidence;

public EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFileForeignResidence;


public BitArray OptimizedAttributes;

public RC_55a4f62f090e92d07d40f0b63ffe2d16() {
OptimizedAttributes = null;
ssENOrderContractFileForeignResidence = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
ssENOrderFileForeignResidence = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderContractFileForeignResidence.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderFileForeignResidence.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderContractFileForeignResidence.OptimizedAttributes = value[0];
    ssENOrderFileForeignResidence.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderContractFileForeignResidence.OptimizedAttributes;
    all[1] = ssENOrderFileForeignResidence.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderContractFileForeignResidence.Read( r, ref index);
ssENOrderFileForeignResidence.Read( r, ref index);
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
public void ReadIM(RC_55a4f62f090e92d07d40f0b63ffe2d16 r) {
this = r;
}


public static bool operator == (RC_55a4f62f090e92d07d40f0b63ffe2d16 a, RC_55a4f62f090e92d07d40f0b63ffe2d16 b) {
if (a.ssENOrderContractFileForeignResidence != b.ssENOrderContractFileForeignResidence) return false;
if (a.ssENOrderFileForeignResidence != b.ssENOrderFileForeignResidence) return false;
return true;
}

public static bool operator != (RC_55a4f62f090e92d07d40f0b63ffe2d16 a, RC_55a4f62f090e92d07d40f0b63ffe2d16 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_55a4f62f090e92d07d40f0b63ffe2d16)) return false;
return (this == (RC_55a4f62f090e92d07d40f0b63ffe2d16)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderContractFileForeignResidence.GetHashCode()
 ^ ssENOrderFileForeignResidence.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderContractFileForeignResidence.RecursiveReset();
ssENOrderFileForeignResidence.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderContractFileForeignResidence.InternalRecursiveSave();
ssENOrderFileForeignResidence.InternalRecursiveSave();
}


public RC_55a4f62f090e92d07d40f0b63ffe2d16 Duplicate() {
RC_55a4f62f090e92d07d40f0b63ffe2d16 t;
t.ssENOrderContractFileForeignResidence = (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)this.ssENOrderContractFileForeignResidence.Duplicate();
t.ssENOrderFileForeignResidence = (EN_096339be3ef098b3762e8897e3a1c095EntityRecord)this.ssENOrderFileForeignResidence.Duplicate();
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
if (head == "ordercontractfileforeignresidence") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFileForeignResidence")) variable.Value = ssENOrderContractFileForeignResidence; else variable.Optimized = true;
variable.SetFieldName("ordercontractfileforeignresidence");
} else if (head == "orderfileforeignresidence") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFileForeignResidence")) variable.Value = ssENOrderFileForeignResidence; else variable.Optimized = true;
variable.SetFieldName("orderfileforeignresidence");
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
if (key == IdOrderContractFileForeignResidence) {
return ssENOrderContractFileForeignResidence;
}
if (key == IdOrderFileForeignResidence) {
return ssENOrderFileForeignResidence;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderContractFileForeignResidence.Key.AsGuid) {
return ssENOrderContractFileForeignResidence;
}
if (attributeKey == IdOrderFileForeignResidence.Key.AsGuid) {
return ssENOrderFileForeignResidence;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderContractFileForeignResidence.FillFromOther((IRecord) other.AttributeGet(IdOrderContractFileForeignResidence));
ssENOrderFileForeignResidence.FillFromOther((IRecord) other.AttributeGet(IdOrderFileForeignResidence));
}
} // RC_55a4f62f090e92d07d40f0b63ffe2d16
/// <summary>
/// RecordList type <code>OrderContractFileForeignResidenceOrderFileForeignResidenceRecordList</code>
///  that represents a record list of <code>OrderContractFile, OrderFile</code>
/// </summary>
public partial class RL_5305c20f972277b55d855aa236dd3fba : GenericRecordList<RC_55a4f62f090e92d07d40f0b63ffe2d16>, IEnumerable, IEnumerator {

protected override RC_55a4f62f090e92d07d40f0b63ffe2d16 GetElementDefaultValue() {
return new RC_55a4f62f090e92d07d40f0b63ffe2d16();
}

public T[] ToArray<T>(Func<RC_55a4f62f090e92d07d40f0b63ffe2d16, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5305c20f972277b55d855aa236dd3fba recordList, Func<RC_55a4f62f090e92d07d40f0b63ffe2d16, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5305c20f972277b55d855aa236dd3fba(RC_55a4f62f090e92d07d40f0b63ffe2d16[] array) {
  RL_5305c20f972277b55d855aa236dd3fba result = new RL_5305c20f972277b55d855aa236dd3fba();
result.InnerFromArray(array);
    return result;
}

public static RL_5305c20f972277b55d855aa236dd3fba ToList<T>(T[] array, Func <T, RC_55a4f62f090e92d07d40f0b63ffe2d16> converter) {
  RL_5305c20f972277b55d855aa236dd3fba result = new RL_5305c20f972277b55d855aa236dd3fba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5305c20f972277b55d855aa236dd3fba FromRestList<T>(RestList<T> restList, Func <T, RC_55a4f62f090e92d07d40f0b63ffe2d16> converter) {
  RL_5305c20f972277b55d855aa236dd3fba result = new RL_5305c20f972277b55d855aa236dd3fba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5305c20f972277b55d855aa236dd3fba() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(14,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_55a4f62f090e92d07d40f0b63ffe2d16> NewList() {
return new RL_5305c20f972277b55d855aa236dd3fba();
}


} // RL_5305c20f972277b55d855aa236dd3fba
}

