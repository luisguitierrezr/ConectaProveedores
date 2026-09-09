namespace ssConectaProveedores {
/// <summary>
/// [Structure] GetErrorDistributionOutStructure (FzbXW2mBoUKBgroEhpMiFQ)
///  <code>ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure</code> that represent
/// s <code>GetErrorDistributionOutStructure</code> <p>Description: </p>
/// </summary>
// Name: GetErrorDistributionOutStructure
public partial struct ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure : ITypedRecord<ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure> {
internal static readonly GlobalObjectKey IdDivision = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zx0BVER2OUC5lLT4oJdGaA");
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QN4RrAFvfEGmg9Br5vDxCQ");
internal static readonly GlobalObjectKey IdApplicantDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WkKHrxLE+UGtsxRjY3sokQ");
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mM7dy+w31k6oiMgpkMr9AA");
internal static readonly GlobalObjectKey IdTabNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0J+cGjP8pUyRUMjtgHlQJA");

public string ssDivision;

public string ssApplicant;

public string ssApplicantDescription;

public string ssDirection;

public int ssTabNumber;


public BitArray OptimizedAttributes;

public ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure() {
OptimizedAttributes = null;
ssDivision = "";
ssApplicant = "";
ssApplicantDescription = "";
ssDirection = "";
ssTabNumber = 0;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssDivision = r.ReadText(index++, "GetErrorDistributionOutStructure.Division", "");
ssApplicant = r.ReadText(index++, "GetErrorDistributionOutStructure.Applicant", "");
ssApplicantDescription = r.ReadText(index++, "GetErrorDistributionOutStructure.ApplicantDescription", "");
ssDirection = r.ReadText(index++, "GetErrorDistributionOutStructure.Direction", "");
ssTabNumber = r.ReadInteger(index++, "GetErrorDistributionOutStructure.TabNumber", 0);
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
public void ReadIM(ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure r) {
this = r;
}


public static bool operator == (ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure a, ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure b) {
if (a.ssDivision != b.ssDivision) return false;
if (a.ssApplicant != b.ssApplicant) return false;
if (a.ssApplicantDescription != b.ssApplicantDescription) return false;
if (a.ssDirection != b.ssDirection) return false;
if (a.ssTabNumber != b.ssTabNumber) return false;
return true;
}

public static bool operator != (ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure a, ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure)) return false;
return (this == (ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDivision.GetHashCode()
 ^ ssApplicant.GetHashCode()
 ^ ssApplicantDescription.GetHashCode()
 ^ ssDirection.GetHashCode()
 ^ ssTabNumber.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure Duplicate() {
ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure t;
t.ssDivision = this.ssDivision;
t.ssApplicant = this.ssApplicant;
t.ssApplicantDescription = this.ssApplicantDescription;
t.ssDirection = this.ssDirection;
t.ssTabNumber = this.ssTabNumber;
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
if (head == "division") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Division")) variable.Value = ssDivision; else variable.Optimized = true;
} else if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssApplicant; else variable.Optimized = true;
} else if (head == "applicantdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicantDescription")) variable.Value = ssApplicantDescription; else variable.Optimized = true;
} else if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssDirection; else variable.Optimized = true;
} else if (head == "tabnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TabNumber")) variable.Value = ssTabNumber; else variable.Optimized = true;
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
if (key == IdDivision) {
return ssDivision;
}
if (key == IdApplicant) {
return ssApplicant;
}
if (key == IdApplicantDescription) {
return ssApplicantDescription;
}
if (key == IdDirection) {
return ssDirection;
}
if (key == IdTabNumber) {
return ssTabNumber;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDivision.Key.AsGuid) {
return ssDivision;
}
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssApplicant;
}
if (attributeKey == IdApplicantDescription.Key.AsGuid) {
return ssApplicantDescription;
}
if (attributeKey == IdDirection.Key.AsGuid) {
return ssDirection;
}
if (attributeKey == IdTabNumber.Key.AsGuid) {
return ssTabNumber;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDivision = (string) other.AttributeGet(IdDivision);
ssApplicant = (string) other.AttributeGet(IdApplicant);
ssApplicantDescription = (string) other.AttributeGet(IdApplicantDescription);
ssDirection = (string) other.AttributeGet(IdDirection);
ssTabNumber = (int) other.AttributeGet(IdTabNumber);
}
} // ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure
/// <summary>
/// RecordList type <code>GetErrorDistributionOutStructureList</code> that represents a record list of
///  <code>GetErrorDistributionOutStructure</code>
/// </summary>
public partial class RL_f4d2c947cdb0bcc211a7a5c1051fc4e1 : GenericRecordList<ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure>, IEnumerable, IEnumerator {

protected override ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure GetElementDefaultValue() {
return new ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure();
}

public T[] ToArray<T>(Func<ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f4d2c947cdb0bcc211a7a5c1051fc4e1 recordList, Func<ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f4d2c947cdb0bcc211a7a5c1051fc4e1(ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure[] array) {
  RL_f4d2c947cdb0bcc211a7a5c1051fc4e1 result = new RL_f4d2c947cdb0bcc211a7a5c1051fc4e1();
result.InnerFromArray(array);
    return result;
}

public static RL_f4d2c947cdb0bcc211a7a5c1051fc4e1 ToList<T>(T[] array, Func <T, ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure> converter) {
  RL_f4d2c947cdb0bcc211a7a5c1051fc4e1 result = new RL_f4d2c947cdb0bcc211a7a5c1051fc4e1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f4d2c947cdb0bcc211a7a5c1051fc4e1 FromRestList<T>(RestList<T> restList, Func <T, ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure> converter) {
  RL_f4d2c947cdb0bcc211a7a5c1051fc4e1 result = new RL_f4d2c947cdb0bcc211a7a5c1051fc4e1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f4d2c947cdb0bcc211a7a5c1051fc4e1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure> NewList() {
return new RL_f4d2c947cdb0bcc211a7a5c1051fc4e1();
}


} // RL_f4d2c947cdb0bcc211a7a5c1051fc4e1
}

